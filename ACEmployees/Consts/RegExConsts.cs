using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ACEmployees.Consts
{
    /// <summary>
    /// Constantes para validar la entrada de texto en los campos del modelo, para aumentar la seguridad y validar data
    /// (Alfredo Castro)
    /// </summary>
    public static class RegExConsts
    {
        //Validar Cédula
        public const string CedulaRegEx = @"^[a-zA-Z0-9-]*$"; //@"^[A-Z]{1}[0-9]{1-15}*$";
        //Validar Nombre
        public const string NameRegEx = @"^[ÁÉÍÓÚÑáéíóúña-zA-Z0-9 ,'._-]*$";
        //Validar Nombre de Usuario
        public const string UserNameRegEx = @"^[a-zA-Z0-9]*$";
        //Validar Documento
        public const string DocumentRegEx = @"^[A-Za-z0-9.-]+$";
        //Validar Dirección (Múltiples lineas)
        public const string AddressRegEx = @"^[ÁÉÍÓÚÑáéíóúña-zA-Z0-9 \n\r\)\(,'.:;_-]*$";
        //Validar Texto (Múltiples lineas)
        public const string MLCommentsRegEx = @"^[ÁÉÍÓÚÑáéíóúña-zA-Z0-9 \n\r\)\(,'.:;_/%*^-]*$"; //MultiLine
        //Validar Texto (Una linea)
        public const string SLCommentsRegEx = @"^[ÁÉÍÓÚÑáéíóúña-zA-Z0-9 \)\(,'.:;_/%*^-]*$"; //SingleLine
        //Validar entrada numérica
        public const string FloatRegEx = @"^[0-9]*(?:\.[0-9]*)?$";
    }
}