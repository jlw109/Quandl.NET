﻿using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Quandl.NET.Infrastructure.Refit
{
    public class LowercaseEnumUrlParameterFormatter : IUrlParameterFormatter
    {
        public string Format(object value, ParameterInfo parameterInfo)
        {
            if (value != null)
                return value is Enum ? value.ToString().ToLower() : value.ToString();
            else
                return null;
        }
    }
}