<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GanttControl.aspx.cs" Inherits="DXWebApplication1.WebForm1" %>

<%@ Register Assembly="DevExpress.Web.ASPxGantt.v21.2, Version=21.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxGantt" TagPrefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 98.3vh; width: 98.5vw">
            <dx:ASPxGantt ID="Gantt" runat="server" Width="100%" Height="100%" ClientInstanceName="clientGantt" AutoExpandAllNodes="True" EnableViewState="false" KeyFieldName="Id"
                TasksDataSourceID="TasksDataSource"
                DependenciesDataSourceID="DependenciesDataSource"
                ResourcesDataSourceID="ResourcesDataSource"
                ResourceAssignmentsDataSourceID="ResourceAssignmentsDataSource" Theme="MaterialCompact" style="margin-top: 0px">
                <SettingsEditing Enabled="True" />
                <SettingsStripLine ShowCurrentTime="true" />
 
                <SettingsGanttView ShowResources="true" TaskTitlePosition="Inside" ViewType="Weeks" />
                <SettingsStripLine ShowCurrentTime="true" />
                <SettingsTaskList AllowSort="true" Width="500">
                    <Columns>
                        <dx:GanttTextColumn FieldName="Title" Caption="Title" Width="300px" />
                        <dx:GanttDateTimeColumn FieldName="StartDate" Caption="Start" Width="100px" />
                        <dx:GanttDateTimeColumn FieldName="EndDate" Caption="End" Width="100px" />
                    </Columns>
                </SettingsTaskList>

                <Mappings>
                    <Task Key="Id" ParentKey="ParentId" Title="Title" Start="StartDate" End="EndDate" Progress="Progress" Color="Color"/>
                    <Dependency Key="Id" PredecessorKey="PredecessorId" SuccessorKey="SuccessorId" DependencyType="Type" />
                    <Resource Key="Id" Name="Name" Color="Color" />
                    <ResourceAssignment Key="Id" TaskKey="TaskId" ResourceKey="ResourceId"/>
                </Mappings>
            </dx:ASPxGantt>


            <%--<asp:SqlDataSource ID="ResourceAssignmentsDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:GanttConnectionString4 %>" SelectCommand="SELECT * FROM [ResourceAssignments]"></asp:SqlDataSource>
            <asp:SqlDataSource ID="ResourcesDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:GanttConnectionString3 %>" SelectCommand="SELECT * FROM [Resources]"></asp:SqlDataSource>
            <asp:SqlDataSource ID="DependenciesDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:GanttConnectionString2 %>" SelectCommand="SELECT * FROM [Dependencies]"></asp:SqlDataSource>
            <asp:SqlDataSource ID="TasksDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:GanttConnectionString %>" SelectCommand="SELECT * FROM [Tasks]"></asp:SqlDataSource>--%>
            <asp:ObjectDataSource ID="TasksDataSource" runat="server"  SelectMethod="GetAllTasks" TypeName="DXWebApplication1.Controller.TasksController" DataObjectTypeName="Core.Task" DeleteMethod="Delete" InsertMethod="Add" UpdateMethod="Update"></asp:ObjectDataSource>
            <asp:ObjectDataSource ID="DependenciesDataSource" runat="server" SelectMethod="GetAllDependencies" TypeName="DXWebApplication1.Controller.DependenciesController" DataObjectTypeName="Core.Dependency" DeleteMethod="Delete" InsertMethod="Add" UpdateMethod="Update"></asp:ObjectDataSource>
            <asp:ObjectDataSource ID="ResourceAssignmentsDataSource" runat="server" SelectMethod="GetAllResourceAssignments" TypeName="DXWebApplication1.Controller.ResourceAssignmentsController" DataObjectTypeName="Core.ResourceAssignment" DeleteMethod="Delete" InsertMethod="Add" UpdateMethod="Update"></asp:ObjectDataSource>
            <asp:ObjectDataSource ID="ResourcesDataSource" runat="server" SelectMethod="GetAllResources" TypeName="DXWebApplication1.Controller.ResourcesController" DataObjectTypeName="Core.Resource" DeleteMethod="Delete" InsertMethod="Add" UpdateMethod="Update"></asp:ObjectDataSource>

        </div>
    </form>
</body>
</html>