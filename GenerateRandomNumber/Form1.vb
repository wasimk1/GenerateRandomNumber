
Public Class Form1

    Public random As New Random()
    Private generatedNumbers As New HashSet(Of String)()
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim uniqueRandomNumber As String = GenerateRandomNumber()
        TextBox1.Text = uniqueRandomNumber
        'Button1.Enabled = False
    End Sub

    Private Function GenerateRandomNumber() As String
        Dim today = DateTime.Now.ToString("yyyyMMddhhmmss")
        'Dim number As Long = random.Next(10000000, 99999999)
        'Dim mon As String
        'Dim year As String
        'Dim d1 As String
        'Dim updatenum As String
        'year = Date.Now.Year
        'mon = DateTime.Today.ToString("MM")
        'd1 = "2001"
        'updatenum = d1 + mon + year + number.ToString()
        'Return updatenum.ToString()
        Return today.ToString()

    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.ReadOnly = True
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class