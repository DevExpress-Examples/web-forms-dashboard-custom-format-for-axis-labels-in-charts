<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128580503/17.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T602710)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# Dashboard for Web Forms - How to use a custom format for axis labels in the Chart Item

<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/t602710/)**
<!-- run online end -->

**Update:** Starting with version **18.2**, we introduced the capability to format any Numeric or Date-Time Value. So, you can set formats demonstrated in this example via the Design mode's UI using the X and Y axis formatting settings without writing additional code.  
However, you can still use approaches demonstrated in this example if you wish to implement your custom formatting not supported by the control.

<p>Although our Dashboards do not provide a way to use custom formats and specify formats for axis labels in a certain case, there is a way to format axis labels manually. This example illustrates how to format axis labels in a custom manner. For this, access the underlying <a href="https://js.devexpress.com/Documentation/15_2/ApiReference/Data_Visualization_Widgets/dxChart/">dxChart</a><strong> </strong>widget in the <a href="https://documentation.devexpress.com/Dashboard/DevExpress.DashboardWeb.Scripts.ASPxClientDashboard.ItemWidgetCreated.event">ItemWidgetCreated</a> and <a href="https://documentation.devexpress.com/Dashboard/DevExpress.DashboardWeb.Scripts.ASPxClientDashboard.ItemWidgetUpdated.event">ItemWidgetUpdated</a> event handlers and customize axis labels in the <a href="http://js.devexpress.com/Documentation/ApiReference/Data_Visualization_Widgets/dxChart/Configuration/argumentAxis/label/?version=15_2#customizeText">dxChart.argumentAxis.label.customizeText</a> or <a href="https://js.devexpress.com/Documentation/15_2/ApiReference/Data_Visualization_Widgets/dxChart/Configuration/valueAxis/label/#customizeText">dxChart.valueAxis.label.customizeText</a> callback function.<br><strong>Note</strong> that printed or exported documents containing a dashboard/dashboard item do not reflect appearance settings applied using the events for accessing of underlying widgets.<br><br>The following two most frequently asked scenarios are represented in this example:<br><br><strong>1. Add the currency sign.<br><br></strong><img src="https://raw.githubusercontent.com/DevExpress-Examples/web-dashboards-how-to-use-a-custom-format-for-axis-labels-in-the-chart-item-t602710/17.1.3+/media/389e50f8-6512-47bb-b8e1-b2a28638b98e.png"></p>

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

<p><br> <strong>2. Use the ones unit format <br><br></strong></p><p><img src="https://raw.githubusercontent.com/DevExpress-Examples/web-dashboards-how-to-use-a-custom-format-for-axis-labels-in-the-chart-item-t602710/17.1.3+/media/c087f566-4b9b-4c65-bbca-3055e191a1f0.png"></p>

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
