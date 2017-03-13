<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Nicole's Assignment 2</title>
    <link rel="stylesheet" type="text/css" href="Styles.css" />
</head>
<body>
    
    <form id="form1" runat="server">
    <div>
    <h1>Metro Bee Club Events</h1>
        <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
        <h3>Click a calendar date to see events</h3>
         <p><asp:Label ID="Event" runat="server" Text=""></asp:Label></p>
     
      
    </div>
    </form>
</body>
</html>
