<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="wtsnApp.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>CARGA DE ARCHIVOS</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Seleccione el archivo que desea guardar<br />
        <br />
    
        <asp:FileUpload ID="fUpload" runat="server" />
        <br />
        <br />
        <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" Text="Guardar Archivo"  />
      
      

    
        <br />
        <br />
      
      

    
    </div>
        <asp:Literal ID="ltlHtml" runat="server"></asp:Literal>
        <br />
    </form>
</body>
</html>
