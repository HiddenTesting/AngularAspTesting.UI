﻿using System.Web;
using System.Web.Optimization;

namespace AngularAspTesting
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/all").Include(
                "~/Scripts/jquery-{version}.js",
                    "~/Scripts/modernizr-*",
                    "~/Scripts/bootstrap.js",
                    "~/Scripts/respond.js",
                    "~/Scripts/angular.js",
                    "~/Scripts/angular-route.js",
                    "~/Scripts/SiteCode/feedbackApp.js",
                    "~/Scripts/SiteCode/*.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/SiteStyle.css"));
        }
    }
}
