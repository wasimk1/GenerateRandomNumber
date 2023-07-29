Public Class Form1
    Public random As New Random()
    Private generatedNumbers As New HashSet(Of String)()
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim uniqueRandomNumber As String = GenerateRandomNumber()
        TextBox1.Text = uniqueRandomNumber
        Button1.Enabled = False
    End Sub

    Private Function GenerateRandomNumber() As String
        Dim number As Long = random.Next(10000000, 99999999)
        Dim d As String
        Dim d1 As String
        Dim updatenum As String
        d = Date.Now.Year
        d1 = "2001"
        updatenum = d1 + d + number.ToString()
        Return updatenum.ToString()

    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.ReadOnly = True
    End Sub
End Class