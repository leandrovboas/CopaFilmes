﻿using System.Web;
using System.Web.Optimization;

namespace Leandrovboas.CopaFilmes.Mvc
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            #region Scripts
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                            "~/Scripts/jquery/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/toastr").Include("~/Scripts/toastr.js"));

            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                "~/Scripts/angular/angular.js",
                "~/Scripts/angular/angular-animate.js",
                "~/Scripts/angular/angular-route.js",
                "~/Scripts/angular/loader.js",
                "~/Scripts/angular/angular-service-wrapper.js"));

            bundles.Add(new ScriptBundle("~/bundles/campeonato")
                .Include("~/modules/campeonato/app.js")
                .Include("~/modules/campeonato/controllers/*.js")
                .Include("~/modules/campeonato/services/*.js")
                .Include("~/modules/campeonato/directives/*.js"));

            bundles.Add(new ScriptBundle("~/bundles/filmes")
                .Include("~/modules/filme/app.js")
                .Include("~/modules/filme/controllers/*.js")
                .Include("~/modules/filme/services/*.js")
                .Include("~/modules/filme/directives/*.js"));

            bundles.Add(new ScriptBundle("~/bundles/ng-service").Include(
              "~/modules/filme/services/app.js",
              "~/modules/filme/services/factories/*.js",
              "~/modules/campeonato/services/factories/*.js"));
            #endregion

            #region Css
            bundles.Add(new StyleBundle("~/Content/css").Include(
                          "~/Content/bootstrap.css",
                          "~/Content/toastr.css")); 
            #endregion
        }
    }
}
