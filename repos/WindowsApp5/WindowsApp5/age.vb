Module age
    Public Const year As Integer = 2018

    Public Function Ageconv()
        Return year - Val(Form1.TextBox1.Text)

    End Function

End Module
