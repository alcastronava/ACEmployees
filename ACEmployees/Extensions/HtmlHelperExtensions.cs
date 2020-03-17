using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ACEmployees.Extensions
{
    /// <summary>
    /// Extensiones para HTMLHelpers (Alfredo Castro)
    /// </summary>
    public static class HtmlHelperExtensions
    {
        /// <summary>
        /// Muestra el texto con los saltos de linea que contenga (Alfredo Castro)
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="html"></param>
        /// <param name="expression"></param>
        /// <returns></returns>
        public static MvcHtmlString DisplayWithBreaksFor<TModel, TValue>(this HtmlHelper<TModel> html, Expression<Func<TModel, TValue>> expression)
        {
            var metadata = ModelMetadata.FromLambdaExpression(expression, html.ViewData);
            var model = html.Encode(metadata.Model).Replace("\r\n", "<br />\r\n");

            if (String.IsNullOrEmpty(model))
                return MvcHtmlString.Empty;

            return MvcHtmlString.Create(model);
        }

        /// <summary>
        /// Se usa para campos del modelo de tipo booleano, si es verdadero muestra "Si"", caso contrario muestra "No" (Alfredo Castro)
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="html"></param>
        /// <param name="expression"></param>
        /// <returns></returns>
        public static MvcHtmlString DisplayForBool<TModel, TValue>(this HtmlHelper<TModel> html, Expression<Func<TModel, TValue>> expression)
        {
            var metadata = ModelMetadata.FromLambdaExpression(expression, html.ViewData);

            var model = html.Encode(metadata.Model);
            if (String.IsNullOrEmpty(model))
                return MvcHtmlString.Empty;

            if (metadata.Model.GetType() != typeof(bool))
                return MvcHtmlString.Empty;

            bool value = (bool)metadata.Model;

            string sValue = value ? "Si" : "No";
            return MvcHtmlString.Create(sValue);
        }
    }
}