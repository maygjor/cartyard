Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class login
    Dim myconnection As New SqlConnection
    Dim mydataadapter As New SqlDataAdapter()

    Dim mydataset As DataSet = New DataSet()
    Dim count As String

    Dim username, usertype, password, result As String
    Private Sub ok_btn_Click(sender As Object, e As EventArgs) Handles ok_btn.Click



        If user_rbtn.Checked Then
            usertype = "1"
        End If
        If admin_rbtn.Checked Then
            usertype = "2"
        End If
        If usertype <> "1" And usertype <> "2" Then
            MessageBox.Show("choose user type")
        End If

        username = name_txt.Text
        password = pass_txt.Text
        mydataadapter.SelectCommand = New SqlCommand()
        myconnection.ConnectionString = "Data Source = mayjor-pc;Initial Catalog=prac1;Integrated Security=True"
        myconnection.Open()
        mydataadapter.SelectCommand.Connection = myconnection
        Select Case usertype
            Case "1"
                mydataadapter.SelectCommand.CommandText = "select username,password from useraccount where username='" + username + "' and password='" + password + "'"

                count = mydataadapter.SelectCommand.ExecuteScalar
                If count = username Then
                    Form5.Show()

                    mydataadapter.SelectCommand.CommandText = "select id from useraccount where username='" + count + "'"
                    user_interface.id = mydataadapter.SelectCommand.ExecuteScalar
                    Form5.accountid = mydataadapter.SelectCommand.ExecuteScalar
                Else
                    MessageBox.Show("user is not found")
                End If

            Case "2"
                mydataadapter.SelectCommand.CommandText = "select id from adminaccount where username='" + username + "' and password='" + password + "'"
                Dim dd As String = mydataadapter.SelectCommand.ExecuteScalar
                mydataadapter.SelectCommand.CommandText = "select username,password from adminaccount where username='" + username + "' and password='" + password + "'"

                count = mydataadapter.SelectCommand.ExecuteScalar

                If count = username Then


                    Select Case dd
                        Case "1"
                            admin.Show()
                            mydataadapter.SelectCommand.CommandText = "select id from adminaccount where username='" + count + "'"
                            form2.id = mydataadapter.SelectCommand.ExecuteScalar

                        Case "2"


                        Case "3"


                        Case "4"



                        Case "5"




                        Case "6"


                    End Select

                Else
                    MessageBox.Show("user is not found")
                End If


        End Select
        myconnection.Close()


        'If usertype = "admin" Then
        '    If username = "mustafa" And password = "123456" Then
        '        form2.Show()
        '    End If
        'End If
        'If usertype = "employee" Then
        '    If username = "ayman" And password = "123456" Then
        '        Form3.Show()
        '    End If
        'End If

    End Sub




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        register.Show()
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        count = 0

    End Sub
End Class
