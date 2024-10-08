﻿using Microsoft.AspNetCore.Mvc;

namespace DreamHouse.Core.Application.Helpers
{
    public static class RedirectRoutesHelper
    {
        public static RedirectToRouteResult routeBasicHome = new RedirectToRouteResult(new { controller = "Home", action = "HomeBasic" });
        public static RedirectToRouteResult routeClientHome = new RedirectToRouteResult(new { controller = "Property", action = "PropertiesForClient" });
        public static RedirectToRouteResult routeAgentHome = new RedirectToRouteResult(new { controller = "Property", action = "PropertiesForAgent" });
        public static RedirectToRouteResult routeAdminHome = new RedirectToRouteResult(new { controller = "Home", action = "AdminHome" });
        public static RedirectToRouteResult routePropertyMaintanceHome = new RedirectToRouteResult(new { controller = "Property", action = "PropertiesForMaintenance" });
        public static RedirectToRouteResult adminMaintanceHome = new RedirectToRouteResult(new { controller = "AdministrationUser", action = "AdminMaintance" });
        public static RedirectToRouteResult developerMaintanceHome = new RedirectToRouteResult(new { controller = "AdministrationUser", action = "DeveloperMaintance" });
        public static RedirectToRouteResult routePropertyTypeIndex = new RedirectToRouteResult(new { controller = "PropertyTypeMaintance", action = "Index" });
        public static RedirectToRouteResult routeSalesTypeIndex = new RedirectToRouteResult(new { controller = "SalesType", action = "Index" });
        public static RedirectToRouteResult routeAgentMaintance = new RedirectToRouteResult(new { controller = "AdministrationUser", action = "AgentMaintance" });
        public static RedirectToRouteResult routeImprovementMaintance = new RedirectToRouteResult(new { controller = "Improvements", action = "Index" });
        public static RedirectToRouteResult routeAccessDenied = new RedirectToRouteResult(new { controller = "Authorization", action = "AccessDenied" });



        public static RedirectToRouteResult routeUndefiniedHome = new RedirectToRouteResult(new { controller = "", action = "" });
    }
}
