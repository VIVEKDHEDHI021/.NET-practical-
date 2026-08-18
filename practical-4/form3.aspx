<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="form3.aspx.cs" Inherits="practical_4.form3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Online Event Registration</title>

    <script type="text/javascript">

        function validateSkills(source, args) {
            var c1 = document.getElementById('<%= CheckBox1.ClientID %>');
            var c2 = document.getElementById('<%= CheckBox2.ClientID %>');
            var c3 = document.getElementById('<%= CheckBox3.ClientID %>');

            args.IsValid = c1.checked || c2.checked || c3.checked;
        }

        function validateTerms(source, args) {
            var terms = document.getElementById('<%= CheckBox4.ClientID %>');

            args.IsValid = terms.checked;
        }

    </script>

</head>

<body>

<form id="form1" runat="server">

    <h1>ONLINE EVENT REGISTRATION</h1>

    <asp:Label ID="Label1" runat="server" Text="Full Name"></asp:Label>
    &nbsp;&nbsp;

    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

    <asp:RequiredFieldValidator
        ID="RequiredFieldValidator1"
        runat="server"
        ControlToValidate="TextBox1"
        ErrorMessage="Name cannot be blank"
        ForeColor="Red"
        Display="Dynamic">
    </asp:RequiredFieldValidator>

    <br /><br />

    <asp:Label ID="Label2" runat="server" Text="Email Id"></asp:Label>
    &nbsp;&nbsp;

    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>

    <asp:RequiredFieldValidator
        ID="RequiredFieldValidator2"
        runat="server"
        ControlToValidate="TextBox2"
        ErrorMessage="Email cannot be blank"
        ForeColor="Red"
        Display="Dynamic">
    </asp:RequiredFieldValidator>

    <asp:RegularExpressionValidator
        ID="RegularExpressionValidator1"
        runat="server"
        ControlToValidate="TextBox2"
        ErrorMessage="Enter a valid email address"
        ForeColor="Red"
        Display="Dynamic"
        ValidationExpression="^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$">
    </asp:RegularExpressionValidator>

    <br /><br />

    <asp:Label ID="Label3" runat="server" Text="Contact No."></asp:Label>
    &nbsp;&nbsp;

    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>

    <asp:RequiredFieldValidator
        ID="RequiredFieldValidator3"
        runat="server"
        ControlToValidate="TextBox3"
        ErrorMessage="Contact number cannot be blank"
        ForeColor="Red"
        Display="Dynamic">
    </asp:RequiredFieldValidator>

    <asp:RegularExpressionValidator
        ID="RegularExpressionValidator2"
        runat="server"
        ControlToValidate="TextBox3"
        ErrorMessage="Contact number must be exactly 10 digits"
        ForeColor="Red"
        Display="Dynamic"
        ValidationExpression="^[0-9]{10}$">
    </asp:RegularExpressionValidator>

    <br /><br />

    <asp:Label ID="Label4" runat="server" Text="College"></asp:Label>
    &nbsp;&nbsp;

    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>

    <asp:RequiredFieldValidator
        ID="RequiredFieldValidator4"
        runat="server"
        ControlToValidate="TextBox4"
        ErrorMessage="College cannot be blank"
        ForeColor="Red"
        Display="Dynamic">
    </asp:RequiredFieldValidator>

    <br /><br />

    <asp:Label ID="Label5" runat="server" Text="Department"></asp:Label>

    <asp:RadioButtonList
        ID="RadioButtonList1"
        runat="server">

        <asp:ListItem Text="Computer" Value="Computer"></asp:ListItem>
        <asp:ListItem Text="Mechanical" Value="Mechanical"></asp:ListItem>
        <asp:ListItem Text="Chemical" Value="Chemical"></asp:ListItem>
        <asp:ListItem Text="Civil" Value="Civil"></asp:ListItem>

    </asp:RadioButtonList>

    <asp:RequiredFieldValidator
        ID="RequiredFieldValidator5"
        runat="server"
        ControlToValidate="RadioButtonList1"
        ErrorMessage="Please select a department"
        ForeColor="Red"
        Display="Dynamic">
    </asp:RequiredFieldValidator>

    <br /><br />

    <asp:Label ID="Label6" runat="server" Text="Event"></asp:Label>
    &nbsp;&nbsp;

    <asp:DropDownList
        ID="DropDownList1"
        runat="server">

        <asp:ListItem Text="Select Event" Value=""></asp:ListItem>
        <asp:ListItem Text="Hackathon" Value="Hackathon"></asp:ListItem>
        <asp:ListItem Text="Workshop" Value="Workshop"></asp:ListItem>
        <asp:ListItem Text="Seminar" Value="Seminar"></asp:ListItem>
        <asp:ListItem Text="Sports" Value="Sports"></asp:ListItem>

    </asp:DropDownList>

    <asp:RequiredFieldValidator
        ID="RequiredFieldValidator6"
        runat="server"
        ControlToValidate="DropDownList1"
        InitialValue=""
        ErrorMessage="Please select an event"
        ForeColor="Red"
        Display="Dynamic">
    </asp:RequiredFieldValidator>

    <br /><br />

    <asp:Label ID="Label7" runat="server" Text="Gender"></asp:Label>
    &nbsp;&nbsp;

    <asp:RadioButtonList
        ID="RadioButtonList2"
        runat="server"
        RepeatDirection="Horizontal">

        <asp:ListItem Text="Male" Value="Male"></asp:ListItem>
        <asp:ListItem Text="Female" Value="Female"></asp:ListItem>

    </asp:RadioButtonList>

    <asp:RequiredFieldValidator
        ID="RequiredFieldValidator8"
        runat="server"
        ControlToValidate="RadioButtonList2"
        ErrorMessage="Please select gender"
        ForeColor="Red"
        Display="Dynamic">
    </asp:RequiredFieldValidator>

    <br /><br />

    <asp:Label ID="Label8" runat="server" Text="Skills"></asp:Label>
    &nbsp;&nbsp;

    <asp:CheckBox
        ID="CheckBox1"
        runat="server"
        Text="C#" />

    &nbsp;&nbsp;

    <asp:CheckBox
        ID="CheckBox2"
        runat="server"
        Text="Python" />

    &nbsp;&nbsp;

    <asp:CheckBox
        ID="CheckBox3"
        runat="server"
        Text="AI" />

    <asp:CustomValidator
        ID="CustomValidator2"
        runat="server"
        ErrorMessage="Please select at least one skill"
        ForeColor="Red"
        ClientValidationFunction="validateSkills"
        ValidateEmptyText="true"
        Display="Dynamic">
    </asp:CustomValidator>

    <br /><br />

    <asp:Label ID="Label9" runat="server" Text="Address"></asp:Label>
    &nbsp;&nbsp;

    <asp:TextBox
        ID="TextBox5"
        runat="server"
        TextMode="MultiLine"
        Rows="5"
        Columns="30">
    </asp:TextBox>

    <asp:RequiredFieldValidator
        ID="RequiredFieldValidator7"
        runat="server"
        ControlToValidate="TextBox5"
        ErrorMessage="Address cannot be blank"
        ForeColor="Red"
        Display="Dynamic">
    </asp:RequiredFieldValidator>

    <br /><br />

    <asp:Label ID="Label10" runat="server" Text="Terms"></asp:Label>
    &nbsp;&nbsp;

    <asp:CheckBox
        ID="CheckBox4"
        runat="server"
        Text="I accept Terms & Conditions" />

    <asp:CustomValidator
        ID="CustomValidator3"
        runat="server"
        ErrorMessage="Please accept Terms & Conditions"
        ForeColor="Red"
        ClientValidationFunction="validateTerms"
        ValidateEmptyText="true"
        Display="Dynamic">
    </asp:CustomValidator>

    <br /><br />

    <asp:Button
        ID="Button1"
        runat="server"
        Text="Submit"
        OnClick="Button1_Click" />

    <br /><br />

        <asp:Label ID="Label11" runat="server"></asp:Label>
    <br />
<br />

</form>

</body>
</html>