using System.Web;
using System.Web.Optimization;

namespace RaysorConsulting
{
    public class BundleConfig
    {
       

        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-3.3.1.min.js",
                        "~/Scripts/umd/popper.js",
                        "~/Scripts/vendors/isotope/isotope-min.js",
                        "~/Scripts/vendors/owl-carousel/owl.carousel.min.js",
                        "~/Scripts/vendors/jquery.ajaxchimp.min.js",
                        "~/Scripts/vendors/mail-script.js",
                        "~/Scripts/vendors/gmaps.min.js",
                        "~/Scripts/vendors/theme.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-2.8.3.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/vendors/linericon/style.css",
                      "~/Content/font-awesome.min.css",
                      "~/Content/vendors/owl-carousel/owl.carousel.min.css",
                      "~/Content/magnific-popup.css",
                      "~/Content/vendors/nice-select/css/nice-select.css"));

        }
    }
}


