<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128537891/13.1.9%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4427)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# Grid View for ASP.NET Web Forms - How to bind the grid to a data source on a button click

This example demonstrates how to use an external button to bind the grid to a data source.

![BindToDataSource](BindToDataSource.gif)

## Overview

Follow the steps below to bind the grid to a data source:

1. Create the [Grid View](https://docs.devexpress.com/AspNet/DevExpress.Web.ASPxGridView) control and enable its [AutoGenerateColumns](https://docs.devexpress.com/AspNet/DevExpress.Web.ASPxGridView.AutoGenerateColumns) property.

    ```aspx
    <dx:ASPxGridView ID="ASPxGridView1" runat="server" KeyFieldName="ProductID"
        OnDataBinding="ASPxGridView1_DataBinding" AutoGenerateColumns="true" >
        <Columns>
            <!-- ... -->
        </Columns>
    </dx:ASPxGridView>
    ```

2. Add a button and handle its server-side `Click` event. In the handler, save the grid's view state and call the [DataBind](https://docs.devexpress.com/AspNet/DevExpress.Web.ASPxWebControl.DataBind) method.

    ```aspx
    <dx:ASPxButton ID="ASPxButton1" runat="server" Text="Bind" OnClick="ASPxButton1_Click" />
    ```

    ```csharp
    protected void ASPxButton1_Click(object sender, EventArgs e) {
        ViewState["needBind"] = true;
        ASPxGridView1.DataBind();
    }
    ```

3. Handle the grid's server-side `DataBinding` event. In the handler, get the data source and assign it to the grid's [DataSource](https://docs.devexpress.com/AspNet/DevExpress.Web.ASPxDataWebControlBase.DataSource) property.

    ```csharp
    protected void ASPxGridView1_DataBinding(object sender, EventArgs e) {
        if (ViewState["needBind"] != null && (bool)ViewState["needBind"])
            ASPxGridView1.DataSource = Product.GetData();
    }
    ```

> **Note**  
> If the grid is already bound to another data source, set the grid's `EnableViewState` property to `false`.

## Files to Review

* [Data.cs](./CS/WebSite/App_Code/Data.cs) (VB: [Data.vb](./VB/WebSite/App_Code/Data.vb))
* [Default.aspx](./CS/WebSite/Default.aspx) (VB: [Default.aspx](./VB/WebSite/Default.aspx))
* [Default.aspx.cs](./CS/WebSite/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/WebSite/Default.aspx.vb))

## Documentation

* [Bind Grid View to Data](https://docs.devexpress.com/AspNet/3719/components/grid-view/concepts/bind-to-data)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=asp-net-web-forms-grid-bind-to-data-source-on-button-click&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=asp-net-web-forms-grid-bind-to-data-source-on-button-click&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
