﻿using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class NavBarController: DemoController {     
        public ActionResult Overview() {
            return DemoView("Overview");
        }
    }
}
