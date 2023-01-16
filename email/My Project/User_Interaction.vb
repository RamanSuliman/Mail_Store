Imports System.Text.RegularExpressions
Imports System.IO.File
Imports System.IO
Imports System.Text

Public Class User_Interaction

    Dim page1 As New Form1

    Dim invaliedEmail As Boolean
    Dim mesageer As String
    Private Sub User_Interaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If File.Exists("C:\Users\Admin\Documents\MyTest.txt") Then
            page1.ShowDialog()
            Me.Hide()
        ElseIf File.Exists("C:\Users\Admin\Desktop\MyTest.txt") Then
            Me.Show()
        End If


        ''Checking if the text is deleted so we can enable the button to generate another one
        If Not File.Exists("C:\Users\Admin\Desktop\MyTest.txt") AndAlso Not File.Exists("C:\Users\Admin\Documents\MyTest.txt") Then
            My.Settings.activatingTextButton = True
            If My.Settings.activatingTextButton = True Then
                btnFileCreator.Enabled = True
            End If
        ElseIf My.Settings.activatingTextButton = False Then
            btnFileCreator.Enabled = False
        End If
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.BackColor = Color.Snow
        Me.TransparencyKey = Color.Snow
        mesageer = "All set up now, an email has sent already"
        invaliedEmail = True
        RadioDefault.Checked = True
    End Sub

    Private Sub BtnFileCreator_Click(sender As Object, e As EventArgs) Handles btnFileCreator.Click

        Dim path As String = "C:\Users\Admin\Documents\MyTest.txt"

        ' Create or overwrite the file.
        Dim fs As FileStream = File.Create(path)

        '' Add text to the file.
        Dim info As Byte() = New UTF8Encoding(True).GetBytes("Please ensure this file isn't deleted, named or edited under any circumstances, as this would prevent the program to function further." + Environment.NewLine + "                                              ☺☺Thanks for your cooperation ☺☺")
        fs.Write(info, 0, info.Length)
        fs.Close()
        My.Settings.activatingTextButton = False

    End Sub
    Private Sub Restricting_Letters_Only(sender As Object, e As KeyPressEventArgs) Handles txtName.KeyPress
        If (e.KeyChar < "a" OrElse e.KeyChar > "z") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub Restrict_Numbers(sender As Object, e As KeyPressEventArgs) Handles txtPhone.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "!" Then
            e.Handled = True
        End If
    End Sub

    Private Function email_checking(text As String) As String
        Dim regex As Regex = New Regex("^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$")
        Dim isValid As Boolean = regex.IsMatch(txtEmail.Text.Trim)
        If Not isValid Then
            lblValidation.Show()
            txtEmail.Clear()
            txtEmail.Select()
            invaliedEmail = False
        Else
            lblValidation.Hide()
        End If
    End Function

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        Dim mes = "Hello Mr." + txtName.Text + "!" + Environment.NewLine + "SomeOne has just logged into your device, please double check to secure your personal files from unauthorized users" + Environment.NewLine + "Details of date & time are given accuratly bellow:"
        Try
            email_checking(txtEmail.Text)
            If txtName.Text = "" AndAlso txtPhone.Text = "" Then
                MsgBox("Please type your name and phone number in the given areas, skipping won't allow you process forward!", MsgBoxStyle.Critical, "Info Missing")
                Return
            End If

            If RadioOwn.Checked = True Then
                page1.message1 = txtMessageContent.Text
                My.Settings.userMessage = txtMessageContent.Text
            ElseIf RadioDefault.Checked = True Then
                page1.message1 = mes
                My.Settings.userMessage = mes
            End If
            If Not File.Exists("C:\Users\Admin\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup\email.exe") Then
                My.Computer.FileSystem.CopyFile(My.Application.Info.DirectoryPath + "\email.exe", "C:\Users\Admin\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup\email.exe")
            End If
            If File.Exists("C:\Users\Admin\Desktop\MyTest.txt") Then
                My.Computer.FileSystem.CopyFile("C:\Users\Admin\Desktop\MyTest.txt", "C:\Users\Admin\Documents\MyTest.txt")
            End If
            If ChHotmail.Checked = True AndAlso invaliedEmail = True Then
                page1.smtpRece = "smtp.hotmail.com"
                My.Settings.userSmtp = "smtp.hotmail.com"
                page1.port1 = 25
                My.Settings.userPort = 25
                My.Settings.userEmail = txtEmail.Text
                My.Settings.userName = txtName.Text
                MsgBox(mesageer, MsgBoxStyle.Information, "Confirmation")
                Me.Hide()
                page1.Show()
            ElseIf ChGmail.Checked = True AndAlso invaliedEmail = True Then
                page1.smtpRece = "smtp.gmail.com"
                My.Settings.userSmtp = "smtp.gmail.com"
                My.Settings.userEmail = txtEmail.Text
                My.Settings.userName = txtName.Text
                page1.port1 = 587
                My.Settings.userPort = 587
                MsgBox(mesageer, MsgBoxStyle.Information, "Confirmation")
                Me.Hide()
                page1.Show()
                ''This line of code, makes the value of closingApplication into True and as long it's true then this form won't be runing firstly
            ElseIf ChOutlook.Checked = True AndAlso invaliedEmail = True Then
                page1.smtpRece = "smtp.office365.com"
                My.Settings.userSmtp = "smtp.office365.com"
                My.Settings.userEmail = txtEmail.Text
                My.Settings.userName = txtName.Text
                page1.port1 = 25
                My.Settings.userPort = 25
                MsgBox(mesageer, MsgBoxStyle.Information, "Confirmation")
                Me.Hide()
                page1.Show()
            ElseIf ChLive.Checked = True AndAlso invaliedEmail = True Then
                page1.smtpRece = "smtp.live.com"
                My.Settings.userSmtp = "smtp.live.com"
                My.Settings.userEmail = txtEmail.Text
                My.Settings.userName = txtName.Text
                page1.port1 = 25
                My.Settings.userPort = 25
                MsgBox(mesageer, MsgBoxStyle.Information, "Confirmation")
                Me.Hide()
                page1.Show()
            Else
                MsgBox("Please ensure you have selected one of the mail servcies and typed in a valied email address", MsgBoxStyle.Critical, "Missing Details")
            End If
            'My.Settings.closingAppliaction = True
            ' saved value needed for this

            My.Settings.Save()
        Catch ex As Exception
            MsgBox(ex.Message)
            Me.Close()
        End Try
    End Sub

    Private Sub TxtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged
        page1.email = txtEmail.Text
    End Sub

    Private Sub ChHotmail_CheckedChanged(sender As Object, e As EventArgs) Handles ChHotmail.CheckedChanged
        If ChHotmail.Checked = True Then
            ChOutlook.Checked = False
            ChLive.Checked = False
            ChGmail.Checked = False
        End If
    End Sub

    Private Sub ChOutlook_CheckedChanged(sender As Object, e As EventArgs) Handles ChOutlook.CheckedChanged
        If ChOutlook.Checked = True Then
            ChHotmail.Checked = False
            ChLive.Checked = False
            ChGmail.Checked = False
        End If
    End Sub

    Private Sub ChLive_CheckedChanged(sender As Object, e As EventArgs) Handles ChLive.CheckedChanged
        If ChLive.Checked = True Then
            ChOutlook.Checked = False
            ChHotmail.Checked = False
            ChGmail.Checked = False
        End If
    End Sub
    Private Sub ChGmail_CheckedChanged(sender As Object, e As EventArgs) Handles ChGmail.CheckedChanged
        If ChGmail.Checked = True Then
            ChOutlook.Checked = False
            ChLive.Checked = False
            ChHotmail.Checked = False
        End If
    End Sub

    Private Sub RadioOwn_CheckedChanged(sender As Object, e As EventArgs) Handles RadioOwn.CheckedChanged
        txtMessageContent.Enabled = True
    End Sub

    Private Sub RadioDefault_CheckedChanged(sender As Object, e As EventArgs) Handles RadioDefault.CheckedChanged
        txtMessageContent.Clear()
        txtMessageContent.Enabled = False
    End Sub

    Private Sub TxtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        My.Settings.userName = txtName.Text
        page1.name1 = txtName.Text
    End Sub

    Private Sub TxtPhone_TextChanged(sender As Object, e As EventArgs) Handles txtPhone.TextChanged
        My.Settings.userPhone = txtPhone.Text
        page1.phone = txtPhone.Text
    End Sub
End Class