﻿using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class SplitterController: DemoController {     
        public ActionResult Overview() {
            return DemoView("Overview");
        }
    }
}
