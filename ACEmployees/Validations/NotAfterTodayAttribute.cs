using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ACEmployees.Validations
{
    public class NotAfterTodayAttribute : ValidationAttribute
    {
        public NotAfterTodayAttribute()
            : base("El campo {0} es inválido.")
        {

        }

        public override bool IsValid(object value)
        {
            if (value != null)
            {
                DateTime date = (DateTime)value;
                return date.Date <= DateTime.Now.Date;
            }
            return true;
        }

    }
}
