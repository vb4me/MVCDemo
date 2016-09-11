Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        Dim vm As New HomeIndexViewModel With {.Phone = "123-123-1234", .Offices = New List(Of AddressViewModel)}

        For x = 1 To 100
            Dim addr As New AddressViewModel With {.Name = $"Office #{x}", .Street = $"{x} N. Main St.", .City = "Lake Mary", .State = "Florida", .Zip = "12345"}
            vm.Offices.Add(addr)
        Next

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
