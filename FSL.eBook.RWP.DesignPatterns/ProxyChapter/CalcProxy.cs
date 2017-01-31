﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FSL.eBook.RWP.DesignPatterns.ProxyChapter
{
    public class CalcProxy : ICalc
    {
        public CalcProxy(User user)
        {
            _user = user;
            _calc = new Calc();        
        }
        
        public string Message { get; set; }

        private User _user;
        private Calc _calc;

        public double Calculate()
        {
            var age = 18;

            if(_user.Age < age)
            {
                Message = $"Must be greater than {age}";
                return 0;
            }

            return _calc.Calculate();
        }
    }
}