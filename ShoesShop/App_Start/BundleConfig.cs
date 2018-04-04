using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace ShoesShop.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/scripts/jquery-2.1.4.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/bootstrap3").Include(
                "~/scripts/bootstrap-3.1.1.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/jquery-easing").Include(
                "~/scripts/easing.js"));

            bundles.Add(new ScriptBundle("~/bundles/scripts").Include(
                "~/scripts/modernizr-2.6.2.min.js",
                "~/scripts/classie.js",
                "~/scripts/demo1.js",
                "~/scripts/minicart.js"));

            bundles.Add(new ScriptBundle("~/bundles/search").Include(
                "~/scripts/search.js"));

            bundles.Add(new ScriptBundle("~/bundles/responsiveslides").Include(
                "~/scripts/responsiveslides.min.js"));

            bundles.Add(new StyleBundle("~/bundles/Content/bootstrap").Include(
            "~/Content/Css/bootstrap.css"));

            bundles.Add(new StyleBundle("~/bundles/Content/font-awesome").Include(
                "~/Content/Css/font-awesome.css"));

            bundles.Add(new StyleBundle("~/bundles/Content/css").Include(
                "~/Content/Css/shop.css",
                "~/Content/Css/style7.css",
                "~/Content/Css/style.css"
                ));           

        }
    }
}