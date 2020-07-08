using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;
using System.Linq;
using WebCalculator.Models;
using static WebCalculator.Models.Collections;

namespace WebCalculator.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Month = Collections.SelectTime.Месяцев.ToString();
            ViewBag.Day = Collections.SelectTime.Дней.ToString();
            ViewBag.Years = Collections.SelectRate.Годовых.ToString();
            ViewBag.Days = Collections.SelectRate.в_день.ToString();
            ViewBag.Everymonth = Collections.SelectPayment.ежемесячно.ToString();
            ViewBag.TenDay = Collections.SelectPayment.каждые_10_дней.ToString();
            ViewBag.FiftenDay = Collections.SelectPayment.каждые_15_дней.ToString();
            return View();
        }

        [HttpPost]
        public IActionResult Index(Credit credit)
        {
            if (TestCorrectData(credit))
            {
                PaymentTable table = CalculateCredit(credit);
                ViewBag.Tabel = table.Payments;
                ViewBag.Over = table.GetOverpayment;
                return View("Result");
            }
            else
            {
                return View("Error");
            }
        }

        public IActionResult Result()
        {
            return View();
        }

        private PaymentTable CalculateCredit(Credit credit)
        {
            PaymentTable table = new PaymentTable();
            double K, i;
            if (credit.SelectTime == SelectTime.Месяцев)
            {
                i = credit.Rate / 100 / 12;
            }
            else
            {
                i = credit.Rate / 100 / 30;
            }
            K = (i * Math.Pow(1 + i, credit.Time))/(Math.Pow(1+i,credit.Time)-1);

            double payment = K * credit.Sum;
            payment -= payment % 0.01;
            double Overpayment = payment * credit.Time - credit.Sum;
            Overpayment -= Overpayment % 0.01;
            table.GetOverpayment = Overpayment;
            

            DateTime date = DateTime.Now.Date;
            double ost = Math.Round(credit.Sum,2);

            for (int j = 1; j <= credit.Time; j++)
            {
                double procent = ost * i;
                procent -= (procent % 0.01);
                
                if (j != credit.Time)
                {
                    double body = Math.Round(payment - procent, 2);
                    ost -= body;
                    ost -= ost % 0.01;
                    table.Add(new Payment(j, date.Date.ToShortDateString(), body, procent, ost));
                }
                else
                {
                    double body = table.Payments.Last().Renains;
                    ost -= body;
                    ost -= ost % 0.01;
                    table.Add(new Payment(j, date.Date.ToShortDateString(), body, procent, ost));
                }

                switch (credit.selectPayment)
                {
                    case SelectPayment.ежемесячно:
                        date = date.AddMonths(1);
                        break;
                    case SelectPayment.каждые_15_дней:
                        date = date.AddDays(15);
                        break;
                    case SelectPayment.каждые_10_дней:
                        date = date.AddDays(10);
                        break;
                }
            }

            return table;
        }

        private bool TestCorrectData(Credit credit)
        {
            double coin = credit.Sum - credit.Sum % 0.01;
            if (coin == credit.Sum)
            {
                if (credit.Time > 0)
                {
                    double rate = credit.Rate - credit.Rate % 0.01;
                    if (rate==credit.Rate)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
