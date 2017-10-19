using System.Web;
using System.Web.Optimization;

namespace RefugeeCamp.Web
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/TemplateScripts").Include(
                        "~/Scripts/Template_Scripts/jquery.min.js",
                        "~/Scripts/Template_Scripts/bootstrap.min.js",
                        "~/Scripts/Template_Scripts/fastclick.js",
                        "~/Scripts/Template_Scripts/nprogress.js",
                        "~/Scripts/Template_Scripts/Chart.min.js",
                        "~/Scripts/Template_Scripts/gauge.min.js",
                        "~/Scripts/Template_Scripts/bootstrap-progressbar.min.js",
                        "~/Scripts/Template_Scripts/icheck.min.js",
                        "~/Scripts/Template_Scripts/skycons.js",
                        "~/Scripts/Template_Scripts/jquery.flot.js",
                        "~/Scripts/Template_Scripts/jquery.flot.pie.js",
                        "~/Scripts/Template_Scripts/jquery.flot.time.js",
                        "~/Scripts/Template_Scripts/jquery.flot.stack.js",
                        "~/Scripts/Template_Scripts/jquery.flot.resize.js",
                        "~/Scripts/Template_Scripts/jquery.flot.orderBars.js",
                        "~/Scripts/Template_Scripts/jquery.flot.spline.min.js",
                        "~/Scripts/Template_Scripts/curvedLines.js",
                        "~/Scripts/Template_Scripts/date.js",
                        "~/Scripts/Template_Scripts/jquery.vmap.js",
                        "~/Scripts/Template_Scripts/jquery.vmap.world.js",
                        "~/Scripts/Template_Scripts/jquery.vmap.sampledata.js",
                        "~/Scripts/Template_Scripts/moment.min.js",
                        "~/Scripts/Template_Scripts/daterangepicker.js",
                        "~/Scripts/Template_Scripts/custom.min.js"));

            bundles.Add(new ScriptBundle("~/Scripts").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new StyleBundle("~/Styles").Include(
                      "~/Styles/bootstrap.min.css",
                      "~/Styles/bootstrap-progressbar-3.3.4.min.css",
                      "~/Styles/custom.min.css",
                      "~/Styles/daterangepicker.css",
                      "~/Styles/font-awesome.min.css",
                      "~/Styles/green.css",
                      "~/Styles/jqvmap.min.css",
                      "~/Styles/nprogress.css"));

            BundleTable.EnableOptimizations = false;

        }
    }
}
