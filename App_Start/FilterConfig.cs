﻿using System.Web;
using System.Web.Mvc;

namespace Create_A_Simple_Web_Page
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
