using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class NavBarController: DemoController {
        public ActionResult DataBinding() {
            return DemoView("DataBinding", new CategoriesData());
        }
    }
}
