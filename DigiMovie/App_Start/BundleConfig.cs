﻿using System.Web;
using System.Web.Optimization;

namespace DigiMovie
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));
            bundles.Add(new ScriptBundle("~/bundles/owl").Include(
                        "~/Scripts/owl.carousel.min.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Owl/css").Include(
                "~/Content/owl.carousel.css", "~/Content/owl.theme.css"));

            bundles.Add(new StyleBundle("~/Content/css-Simplex-Theme").Include("~/Content/Simplex-bootstrap.css",
                      "~/Content/bootstrap.css"));

            bundles.Add(new StyleBundle("~/Content/css-Simplex-Theme").Include("~/Content/Yeti-bootstrap.css",
                      "~/Content/bootstrap.css"));

            bundles.Add(new StyleBundle("~/Content/css-Simplex-Theme").Include("~/Content/Darkly-bootstrap.css",
                      "~/Content/bootstrap.css"));

            bundles.Add(new StyleBundle("~/Content/css-Simplex-Theme").Include("~/Content/Cerulean-bootstrap.css",
                      "~/Content/bootstrap.css"));

            bundles.Add(new StyleBundle("~/Content/css-Simplex-Theme").Include("~/Content/Readable-bootstrap.css",
                      "~/Content/bootstrap.css"));
        }
    }
}
