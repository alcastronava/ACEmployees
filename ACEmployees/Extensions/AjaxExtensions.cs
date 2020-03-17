using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ACEmployees.Extensions
{
    public static class AjaxExtensions
    {
        /// <summary>
        /// Determina si la petición HTTP es de tipo AJAX (Alfredo Castro)
        /// </summary>
        /// <returns>
        /// Devuelve true si es tipo AJAX o falso en caso contrario
        /// </returns>
        /// <param name="request">The HTTP request.</param>
        public static bool IsAjaxRequest(this HttpRequest request)
        {
            if (request == null)
                throw new ArgumentNullException("request");

            if (request.Headers != null)
                return request.Headers["X-Requested-With"] == "XMLHttpRequest";
            return false;
        }
    }
}