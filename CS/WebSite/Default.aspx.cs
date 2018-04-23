using System;

public partial class _Default : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        
    }    
    
    protected void ASPxButton1_Click(object sender, EventArgs e) {
        ViewState["needBind"] = true;
        ASPxGridView1.DataBind();
    }

    protected void ASPxGridView1_DataBinding(object sender, EventArgs e) {
        if (ViewState["needBind"] != null && (bool)ViewState["needBind"])
            ASPxGridView1.DataSource = Product.GetData();
    }
}