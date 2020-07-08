﻿$(document).ready(function () {

    $("#myform-1").validate({
        // правила для полей с именем и паролем
        rules: {

            Sum: {
                required: true, // поле для имени обязательное для заполнения
                
                digits: true,
            },
            Time: {
                required: true, // поле для имени обязательное для заполнения
                range: [1, 31],
                digits: true,
            },

            Rate: {
                required: true, // поле для имени обязательное для заполнения
                range: [1, 100],
                digits: true,
            },
        },
        // сообщение для поля с именем и пароля, если что-то было не по правилам
        messages: {

            Sum: {
                required: " Это поле обязательно для заполнения", // поле для имени обязательное для заполнения
               
                digits: " Поле должно содержать только цифры",
            },
            Time: {
                required: " Это поле обязательно для заполнения", // поле для имени обязательное для заполнения
                range: " Поле должно содержать поле от 1 до 31",
                digits: " Поле должно содержать только цифры",
,
            },

            Rate: {
                required: " Это поле обязательно для заполнения", // поле для имени обязательное для заполнения
                range: " Поле должно содржать значенияот 1 до 100",
                digits: " Поле должно содержать только цифры",
            },
            
        }

    });

});