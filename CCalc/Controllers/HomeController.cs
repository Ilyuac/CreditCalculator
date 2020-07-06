using CCalc.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;
using System.Linq;

namespace CCalc.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Credit credit)
        {
            PaymentTable table = CalculateCredit(credit);
            ViewBag.Tabel = table.Payments;
            ViewBag.Over = table.GetOverpayment;
            return View("Result");
        }

        public IActionResult Result()
        {

            return View();
        }

        private PaymentTable CalculateCredit(Credit credit)
        {
            PaymentTable table = new PaymentTable();
            double K, i;
            if (!credit.isDayOrYear)
            {
                i = credit.Rate / 100 / 12;
            }
            else
            {
                i = credit.Rate / 100 / 30;
            }
            K = (i * Math.Pow(1 + i, credit.Time))/(Math.Pow(1+i,credit.Time)-1);

            double payment = Math.Round(K * credit.Sum,2);
            table.GetOverpayment = Math.Round(payment * credit.Time - credit.Sum, 2);

            DateTime date = DateTime.Now.Date;
            double ost = Math.Round(credit.Sum,2);

            for (int j = 1; j <= credit.Time; j++)
            {
                double procent = Math.Round(ost * i,2);
                double body = Math.Round(payment - procent,2);
                ost = Math.Round(ost - body,2);
                table.Add(new Payment(j, date.Date.ToShortDateString(), body, procent, ost));
                date.AddMonths(1);
            }
            table.Payments.Last().Renains = 0.0;

            return table;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
