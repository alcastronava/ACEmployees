using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace ACEmployees.ModelBinders
{
    public class DateTimeModelBinder : DefaultModelBinder
    {
        /// <summary>
        /// ModelBinder para permitir la entrada de fechas en formato dd/mm/yyyy (Alfredo Castro)
        /// </summary>
        /// <param name="controllerContext"></param>
        /// <param name="bindingContext"></param>
        /// <returns></returns>
        public override object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            var value = bindingContext.ValueProvider.GetValue(bindingContext.ModelName);

            if (value == null)
            {
                return null;
            }

            DateTime dateTime;

            var isDate = DateTime.TryParseExact(value.AttemptedValue, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateTime);
            //DateTime.TryParse(value.AttemptedValue, Thread.CurrentThread.CurrentUICulture, DateTimeStyles.None, out dateTime);
            if (!isDate)
            {
                bindingContext.ModelState.AddModelError(bindingContext.ModelName, "La Fecha no es válida." /*ModelValidationResources.InvalidDateTime*/);
                return null;
            }

            return dateTime;
        }
    }
}