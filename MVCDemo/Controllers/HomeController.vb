Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        Dim vm As New HomeIndexViewModel With {.Street = "123 Main St.", .City = "Lake Mary", .State = "Florida", .Zip = "12345", .Phone = "123-123-1234"}

        Return View(vm)
    End Function

    Function About() As ActionResult
        ViewData("Message") = "Your application description page."

        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "Your contact page."

        Return View()
    End Function
End Class
