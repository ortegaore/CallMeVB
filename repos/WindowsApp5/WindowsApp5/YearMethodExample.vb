Module YearMethodExample
    Public Sub Main()
        ' Initialize date variable and display year
        'Dim date1 As Date = #01/01/2008 6:32AM#
        Dim date1 As Date = Date.Today.Year
        ' Console.WriteLine(date1.Year)       ' Displays 
    End Sub
    TextBox1.Text = date1
End Module
