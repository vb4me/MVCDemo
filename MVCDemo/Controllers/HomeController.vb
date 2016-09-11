Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        Dim vm As New HomeIndexViewModel With {.Phone = "123-123-1234"}
        vm.NorthOffice = New AddressViewModel With {.Street = "123 N. Main St.", .City = "Lake Mary", .State = "Florida", .Zip = "12345"}
        vm.SouthOffice = New AddressViewModel With {.Street = "123 S. Main St.", .City = "Lake Mary", .State = "Florida", .Zip = "12345"}
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
