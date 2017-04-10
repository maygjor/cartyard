Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class register
    Dim reid As Integer
    Dim reuser As String
    Dim repass As String
    Dim email As String
    Dim count As Integer
    Dim coucc, vount As String
    Public id As String
    Private Sub register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        id = 1
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CheckBox1.Checked Then
            If txt_password.Text = txt_repass.Text Then
                Dim con As New SqlConnection
                Dim cmd As New SqlCommand

                Try
                    'con.ConnectionString = "data source=MAYJOR-PC;initial catalog =prac1;persist security info=true;user id=; password="
                    con.ConnectionString = "Data Source = mayjor-pc;Initial Catalog=prac1;Integrated Security=True"
                    con.Open()

                    cmd.Connection = con
                    cmd.CommandText = "select username from useraccount where username='" + txt_username.Text + "'"
                    cmd.ExecuteNonQuery()
                    Dim s As String = cmd.ExecuteScalar
                    If s = "" Then
                        cmd = New SqlCommand("select id from useraccount where id='" + id + "'", con)
                        cmd.ExecuteNonQuery()
                        coucc = cmd.ExecuteScalar

                        If coucc <> "" Then
                            cmd = New SqlCommand("insert into useraccount (id,username,password,email)values('" + geno() + "','" + txt_username.Text + "','" + txt_password.Text + "','" + txt_email.Text + "')", con)
                            cmd.ExecuteNonQuery()
                        Else
                            cmd = New SqlCommand("insert into useraccount (id,username,password,email)values('" + id + "','" + txt_username.Text + "','" + txt_password.Text + "','" + txt_email.Text + "')", con)
                            cmd.ExecuteNonQuery()

                        End If



                        con.Close()
                    Else
                        MsgBox("username is used")
                    End If
                Catch ex As Exception

                    geno()
                Finally

                    register2.Show()
                    register2.Focus()
                    Me.Hide()

                End Try
                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''






            Else
                MessageBox.Show("password is Not match")

            End If
        Else
            MessageBox.Show("read and agree to the customer agreement and the user polices")
        End If
    End Sub

    Function geno()
        Do Until coucc = "" And vount = ""
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            'con.ConnectionString = "data source=MAYJOR-PC;initial catalog =prac1;persist security info=true;user id=; password="
            con.ConnectionString = "Data Source = mayjor-pc;Initial Catalog=prac1;Integrated Security=True"
            con.Open()

            cmd.Connection = con

            cmd = New SqlCommand("select id from useraccount where id='" + id + "'", con)
            cmd.ExecuteNonQuery()
            coucc = cmd.ExecuteScalar
            If coucc <> "" Then


                id = Val(id) + 1
            End If

            ''''''''''''''''''''

            cmd = New SqlCommand("select id from accounts where id='" + id + "'", con)
            cmd.ExecuteNonQuery()
            vount = cmd.ExecuteScalar
            If vount <> "" Then
                id = Val(id) + 1
            End If



        Loop


        Return id
    End Function


End Class