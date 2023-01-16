Imports System.Net.Mail
Public Class Form1
    Private emailmessage As New MailMessage
    Private databaseMessage As New MailMessage
    Private currentTime As Date
    Private messageBox As MessageBox
    Public message1 As String
    Public email As String
    Public port1 As Integer
    Public smtpRece As String
    Public name1 As String
    Public phone As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        currentTime = Now
        message1 = My.Settings.userMessage
        email = My.Settings.userEmail
        port1 = My.Settings.userPort
        smtpRece = My.Settings.userSmtp
        name1 = My.Settings.userName
        phone = My.Settings.userPhone

        Try
            emailmessage.From = New MailAddress("Protection870@gmail.com")
            emailmessage.To.Add(email)
            emailmessage.Subject = "Access notification!"
            emailmessage.Body = message1 + Environment.NewLine + "The logged in occured at: " + currentTime
            Dim smtp As New SmtpClient(smtpRece)
            smtp.Port = port1

            ''This tell the program to don't let random address be sent by
            ''or it prevents sending worng approavles
            smtp.UseDefaultCredentials = False
            smtp.EnableSsl = True
            ''This tells the Simple Mail Transfer Protocl to get those docemnts and access details of our email
            smtp.Credentials = New System.Net.NetworkCredential("Protection870@gmail.com", "Bvcxz123")
            smtp.Send(emailmessage)
        Catch ex As Exception
            MsgBox(ex.Message)
            Me.Close()
            User_Interaction.Close()
        End Try
        Try
            databaseMessage.From = New MailAddress("Protection870@gmail.com")
            databaseMessage.To.Add("raman.suliman1997@gmail.com")
            databaseMessage.Subject = "New Customer"
            databaseMessage.Body = message1 + Environment.NewLine + "The logged in occured at: " + currentTime + Environment.NewLine + "Email: " + email + Environment.NewLine + "Name: " + name1 + Environment.NewLine + "Phone: " + phone
            Dim smtp As New SmtpClient(smtpRece)
            smtp.Port = port1

            ''This tell the program to don't let random address be sent by
            ''or it prevents sending worng approavles
            smtp.UseDefaultCredentials = False
            smtp.EnableSsl = True
            ''This tells the Simple Mail Transfer Protocl to get those docemnts and access details of our email
            smtp.Credentials = New System.Net.NetworkCredential("Protection870@gmail.com", "Bvcxz123")
            smtp.Send(databaseMessage)
            Me.Close()
            User_Interaction.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Me.Close()
            User_Interaction.Close()
        End Try
    End Sub
End Class
