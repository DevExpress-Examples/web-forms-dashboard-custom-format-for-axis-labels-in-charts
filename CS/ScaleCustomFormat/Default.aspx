﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ScaleCustomFormat.Default" %>

<%@ Register Assembly="DevExpress.Dashboard.v24.2.Web.WebForms, Version=24.2.1.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.DashboardWeb" TagPrefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <script type="text/javascript">
        function onItemWidgetCreated(s, e) {
            if (e.ItemName == "chartDashboardItem1") {
                var widget = e.GetWidget();
                var customizeText = widget.option('valueAxis[0].label.customizeText');
                widget.option('valueAxis[0].label.customizeText', function (args) {
                    var text = $.proxy(customizeText, args)(args);
                    return '$' + text;
                });
            }
            if (e.ItemName == "chartDashboardItem2") {
                var widget = e.GetWidget();
                widget.option('valueAxis[0].label.customizeText', function (args) {
                    return args.value.toLocaleString();
                });
            }
            
        }
    </script>

</head>
<body>
    <form id="form1" runat="server">
        <div>
            <dx:ASPxDashboard ID="ASPxDashboard1" ClientInstanceName="webDashboard" runat="server" WorkingMode="ViewerOnly"
                OnConfigureDataConnection="ASPxDashboard1_ConfigureDataConnection" DashboardXmlPath="~/App_Data/Dashboards/T602710.xml" >
                <ClientSideEvents ItemWidgetCreated="onItemWidgetCreated" />
            </dx:ASPxDashboard>            
        </div>
    </form>
</body>
</html>
