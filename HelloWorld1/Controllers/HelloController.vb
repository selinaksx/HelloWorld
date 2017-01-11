Imports System.Web.Mvc

Namespace Controllers
    Public Class HelloController
        Inherits Controller

        ' GET: Hello
        Function Hello() As ActionResult
            Return View()
        End Function
    End Class
End Namespace