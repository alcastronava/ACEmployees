using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ACEmployees.Enums
{
    public enum PageSize
    {
#if DEBUG
        [Display(Name = "1")]
        size1 = 1,
#endif
        [Display(Name = "5")]
        size5 = 5,
        [Display(Name = "10")]
        size10 = 10,
        [Display(Name = "20")]
        size20 = 20,
        [Display(Name = "30")]
        size30 = 30,
        [Display(Name = "40")]
        size40 = 40,
        [Display(Name = "50")]
        size50 = 50
    }
}