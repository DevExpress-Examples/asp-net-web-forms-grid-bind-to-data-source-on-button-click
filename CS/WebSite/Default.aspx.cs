using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.Web.ASPxGridView;

public partial class _Default : System.Web.UI.Page {
    protected void Page_Init(object sender, EventArgs e) {
        if (Session["bound"] != null && (bool)Session["bound"] == true) {
            ASPxGridView1.DataBind();
        }
    }
    protected void ASPxGridView1_DataBinding(object sender, EventArgs e) {
        ASPxGridView grid = sender as ASPxGridView;
        grid.DataSource = GetData();
    }
    protected void ASPxButton1_Click(object sender, EventArgs e) {
        ASPxGridView1.DataBind();
        Session["bound"] = true;
    }
    private object GetData() {
        return Enumerable.Range(0, 10);
    }
}