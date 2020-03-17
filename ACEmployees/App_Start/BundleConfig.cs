using System.Web;
using System.Web.Optimization;

namespace ACEmployees
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquery-ajax").Include(
                      "~/Scripts/jquery.unobtrusive-ajax.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap-datepicker").Include(
                      "~/Scripts/bootstrap-datepicker/bootstrap-datepicker.min.js",
                      "~/Scripts/bootstrap-datepicker/bootstrap-datepicker.es.min.js"));

            bundles.Add(new StyleBundle("~/Content/bootstrap-datepicker").Include(
                      "~/Content/bootstrap-datepicker/bootstrap-datepicker3.min.css"));

            bundles.Add(new ScriptBundle("~/bundles/jquery-mask").Include(
                      "~/Scripts/jquery.mask/jquery.mask.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap-toggle").Include(
                      "~/Scripts/bootstrap4-toggle/bootstrap4-toggle.min.js"));

            bundles.Add(new StyleBundle("~/Content/bootstrap-toggle").Include(
                      "~/Content/bootstrap4-toggle/bootstrap4-toggle.min.css"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
        }
    }
}
