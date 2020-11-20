<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserData.aspx.cs" Inherits="assignment_1.UserData" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="background-color:black; color: white; text-align: center">
            <br />
            <h1>Enter User Data</h1>
            <br />
        </div>
        <br /> <br />
        <div style="height: 533px; text-align: center" >
            <asp:Panel ID="Panel1" runat="server" Height="528px">
                <asp:Label ID="Label1" runat="server" Text="First Name :"></asp:Label>
                <asp:TextBox ID="txtFirstName" runat="server" style="margin-left: 25px" Width="250px"></asp:TextBox>
                <asp:Label ID="errFirstName" runat="server" ForeColor="#CC0000" Text="*Enter FirstName" Visible="False"></asp:Label>
                <br />
                <br />
                <asp:Label ID="Label2" runat="server" Text="Last Name :"></asp:Label>
                <asp:TextBox ID="txtLastName" runat="server" style="margin-left: 29px" Width="248px"></asp:TextBox>
                <asp:Label ID="errLastName" runat="server" ForeColor="#CC0000" Text="*Enter LastName" Visible="False"></asp:Label>
                <br />
                <br />
                <asp:Label ID="Label3" runat="server" Text="Email :"></asp:Label>
                <asp:TextBox ID="txtEmail" runat="server" style="margin-left: 60px" Width="248px"></asp:TextBox>
                <asp:Label ID="errEmail" runat="server" ForeColor="#CC0000" Text="*Enter Email" Visible="False"></asp:Label>
                <br />
                <br />
                <asp:Label ID="Label4" runat="server" Text="Mobile No. :"></asp:Label>
                <asp:TextBox ID="txtMobile" runat="server" style="margin-left: 23px" Width="249px"></asp:TextBox>
                <asp:Label ID="errMobile" runat="server" ForeColor="#CC0000" Text="*Enter Mobile No." Visible="False"></asp:Label>
                <br />
                <br />
                <asp:Label ID="Label5" runat="server" Text="Address :"></asp:Label>
                <asp:TextBox ID="txtAddress" runat="server" style="margin-left: 42px" Width="251px"></asp:TextBox>
                <asp:Label ID="errAddress" runat="server" ForeColor="#CC0000" Text="*Enter Address" Visible="False"></asp:Label>
                <br />
                <br />
                <asp:Label ID="Label6" runat="server" Text="Gender :"></asp:Label>
                 &nbsp &nbsp &nbsp &nbsp &nbsp<asp:RadioButton ID="radMale" runat="server" Text="Male" GroupName="radGender" />
                 &nbsp &nbsp &nbsp &nbsp <asp:RadioButton ID="radFemale" runat="server" Text="Female" GroupName="radGender" />
                <asp:Label ID="errGender" runat="server" ForeColor="#CC0000" Text="*Select One" Visible="False"></asp:Label>
                <br />
                <br />
                <asp:Button ID="btnSave" runat="server" style="margin-left: 78px" Text="Save" Width="72px" OnClick="btnSave_Click" />
                <asp:Button ID="btnReset" runat="server" style="margin-left: 24px" Text="Reset" Width="74px" OnClick="btnReset_Click" />
                <br />
                <br />
            </asp:Panel>
        </div>
    </form>
</body>
</html>
