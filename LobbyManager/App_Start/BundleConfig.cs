using System.Web;
using System.Web.Optimization;

namespace LobbyManager
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

            bundles.Add(new StyleBundle("~/Custom/css").Include(
                      "~/CustomStyle/bootstrap/dist/css/bootstrap.min.css",
                      "~/CustomStyle/metisMenu/dist/metisMenu.min.css",
                      "~/CustomStyle/datatables-plugins/integration/bootstrap/3/dataTables.bootstrap.css",
                      "~/CustomStyle/datatables-responsive/css/dataTables.responsive.css",
                      "~/CustomStyle/morrisjs/morris.css",
                      "~/CustomStyle/font-awesome/css/font-awesome.min.css",
                      "~/CustomStyle/sb-admin-2/sb-admin-2.css",
                      "~/CustomStyle/sb-admin-2/timeline.css"));

            bundles.Add(new ScriptBundle("~/Custom/bootstrap").Include(
                      "~/CustomStyle/jquery/dist/jquery.min.js",
                      "~/CustomStyle/bootstrap/dist/js/bootstrap.min.js",
                      "~/CustomStyle/metisMenu/dist/metisMenu.min.js",
                      "~/CustomStyle/sb-admin-2/sb-admin-2.js"));
        }
    }
}
