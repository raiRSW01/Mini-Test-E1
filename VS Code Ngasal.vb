Module Program
    Sub Start_Program()
        Dim A As Integer = 10
        Dim B As String = ""
        Dim AA As String = ""

        If A == 10 Then
            B = "Hello There!"
        ElseIf A > 10 Then
            B = "Hey There!"
        ElseIf A < 10 Then
            B = "Halo{A}"
        End If

        Console.WriteLine(B)
        AA = Console.ReadLine()
    End Sub
End Module