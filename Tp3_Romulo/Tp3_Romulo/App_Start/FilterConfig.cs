﻿using System.Web;
using System.Web.Mvc;

namespace Tp3_Romulo
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
