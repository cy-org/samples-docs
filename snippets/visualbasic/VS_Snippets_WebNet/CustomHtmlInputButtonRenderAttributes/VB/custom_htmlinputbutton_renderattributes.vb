 ' <Snippet2>
Imports System.Web
Imports System.Security.Permissions

Namespace Samples.AspNet.VB.Controls
    <AspNetHostingPermission(SecurityAction.Demand, Level:=AspNetHostingPermissionLevel.Minimal)> _
    Public NotInheritable Class CustomHtmlInputButtonRenderAttributes
        Inherits System.Web.UI.HtmlControls.HtmlInputButton

        Protected Overrides Sub RenderAttributes(ByVal writer As System.Web.UI.HtmlTextWriter)

            ' Call the base class's RenderAttributes method.
            MyBase.RenderAttributes(writer)

            ' Write out the HtmlInputButton control's Title tag.
            writer.Write(" Title=""Text from RenderAttributes.""")
        End Sub
    End Class

End Namespace
' </Snippet2>
