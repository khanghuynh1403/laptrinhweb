using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;

namespace HuynhNhatKhang__Bigschool.ViewModels
{
    public class ValidTime : ValidationAttribute
    {
        public object DatetimeStyles { get; private set; }

        public override bool IsValid(object value)
        {
            DateTime dateTime;
            var IsValid = DateTime.TryParseExact(Convert.ToString(value),
                "HH:mm",
            CultureInfo.CurrentCulture,
            DateTimeStyles.None,
            out dateTime);

            return IsValid;
        }
    }
}