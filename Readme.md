<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128580503/17.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/t602710)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# Dashboard for Web Forms - How to use a custom format for axis labels in the Chart Item

<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/128580503/)**
<!-- run online end -->

---

**Update:** Starting with version **18.2**, we introduced the capability to format any Numeric or Date-Time Value. So, you can set formats demonstrated in this example via the Design mode's UI using the X and Y axis formatting settings without writing additional code.  
However, you can still use approaches demonstrated in this example if you wish to implement your custom formatting not supported by the control.

---

This example illustrates how to format axis labels in a custom manner. For this, access the underlying [dxChart](https://js.devexpress.com/Documentation/ApiReference/UI_Components/dxChart/) widget in the [ItemWidgetCreated](https://docs.devexpress.com/Dashboard/js-DevExpress.Dashboard.Web.WebForms.ASPxClientDashboard?p=netframework#js_aspxclientdashboard_itemwidgetcreated) and [ItemWidgetUpdated](https://docs.devexpress.com/Dashboard/js-DevExpress.Dashboard.Web.WebForms.ASPxClientDashboard?p=netframework#js_aspxclientdashboard_itemwidgetupdated) event handlers and customize axis labels in the [dxChart.argumentAxis.label.customizeText](https://js.devexpress.com/Documentation/ApiReference/UI_Components/dxChart/Configuration/argumentAxis/label/#customizeText) or [dxChart.valueAxis.label.customizeText](https://js.devexpress.com/Documentation/ApiReference/UI_Components/dxChart/Configuration/valueAxis/label/#customizeText) callback function.  
**Note** that printed or exported documents containing a dashboard/dashboard item do not reflect appearance settings applied using the events for accessing of underlying widgets.  

The following two most frequently asked scenarios are represented in this example:  

1. Add the currency sign.  

![](https://raw.githubusercontent.com/DevExpress-Examples/web-dashboards-how-to-use-a-custom-format-for-axis-labels-in-the-chart-item-t602710/17.1.3+/media/389e50f8-6512-47bb-b8e1-b2a28638b98e.png)

```js
        function onItemWidgetCreated(s, e) {
            if (e.ItemName == "chartDashboardItem1") {
                var widget = e.GetWidget();
                var customizeText = widget.option('valueAxis[0].label.customizeText');
                widget.option('valueAxis[0].label.customizeText', function (args) {
                    var defaultText = $.proxy(customizeText, args)(args);
                    return '$' + defaultText;
                });
            }
            ...            
        }

```

2. Use the ones unit format.

<img src="https://raw.githubusercontent.com/DevExpress-Examples/web-dashboards-how-to-use-a-custom-format-for-axis-labels-in-the-chart-item-t602710/17.1.3+/media/c087f566-4b9b-4c65-bbca-3055e191a1f0.png">

```js
        function onItemWidgetCreated(s, e) {
            ...
            if (e.ItemName == "chartDashboardItem2") {
                var widget = e.GetWidget();
                widget.option('valueAxis[0].label.customizeText', function (args) {
                    return args.value.toLocaleString();
                });
            }
        }
 
```

## Files to Review

* [Default.aspx](./CS/ScaleCustomFormat/Default.aspx) (VB: [Default.aspx](./VB/ScaleCustomFormat/Default.aspx))
* [Default.aspx.cs](./CS/ScaleCustomFormat/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/ScaleCustomFormat/Default.aspx.vb))
* [Global.asax](./CS/ScaleCustomFormat/Global.asax) (VB: [Global.asax](./VB/ScaleCustomFormat/Global.asax))
* [Global.asax.cs](./CS/ScaleCustomFormat/Global.asax.cs) (VB: [Global.asax.vb](./VB/ScaleCustomFormat/Global.asax.vb))

## Documentation

- [Access to Underlying Widgets in ASP.NET Web Forms](https://docs.devexpress.com/Dashboard/117573/web-dashboard/aspnet-web-forms-dashboard-control/access-to-underlying-widgets)

## More Examples

- [Dashboard for WinForms - How to use a custom format for axis labels in the Chart Item](https://github.com/DevExpress-Examples/winforms-dashboards-how-to-use-a-custom-format-for-axis-labels-in-the-chart-item-t597204)
