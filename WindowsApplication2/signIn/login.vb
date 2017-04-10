
Imports System.Data.Sql
Imports System.Data.SqlClient



Public Class login
    Dim port As String
    Dim i As Integer = 0
    Dim ports As String()
    Dim strHostName As String
    Dim strIPAddress As Net.IPAddress
    Dim hostAdr As Net.IPAddress
    Dim myconnection As New SqlConnection
    Dim con = myconnection
    Dim mydataadapter As New SqlDataAdapter()
    Dim mydataset As DataSet = New DataSet()
    Dim count As String
    Dim cmd = New SqlCommand
    Public cash As Decimal
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
        myconnection.ConnectionString = "Data Source = mayjor-pc;Initial Catalog=trade1;Integrated Security=True"
        myconnection.Open()
        mydataadapter.SelectCommand.Connection = myconnection
        Select Case usertype
            Case "1"
                mydataadapter.SelectCommand.CommandText = "select username,password from useraccount where username='" + username + "' and password='" + password + "'"

                count = mydataadapter.SelectCommand.ExecuteScalar
                If count = username Then
                    mydataadapter.SelectCommand.CommandText = "select id from useraccount where username='" + count + "'"
                    Dim id As Integer = mydataadapter.SelectCommand.ExecuteScalar
                    mydataadapter.SelectCommand.CommandText = "select cash from useraccount where username='" + count + "'"
                    cash = mydataadapter.SelectCommand.ExecuteScalar


                    Dim trade As New trades
                    connected(id, username)

                    GetIPAddress()
                    trade.id = id
                    trade.myname = username
                    trade.cash = cash
                    trade.ip = strIPAddress
                    trade.port = port
                    trade.loc_addr = hostAdr
                    trade.host = strHostName
                    trade.Show()

                Else
                    MessageBox.Show("user Is Not found")
                End If

            Case "2"
                mydataadapter.SelectCommand.CommandText = "Select id from adminaccount where username='" + username + "' and password='" + password + "'"
                Dim dd As String = mydataadapter.SelectCommand.ExecuteScalar
                mydataadapter.SelectCommand.CommandText = "select username,password from adminaccount where username='" + username + "' and password='" + password + "'"

                count = mydataadapter.SelectCommand.ExecuteScalar

                If count = username Then


                    Select Case dd
                        Case "1"
                            admin.Show()
                            mydataadapter.SelectCommand.CommandText = "select id from adminaccount where username='" + count + "'"
                            Form2.id = mydataadapter.SelectCommand.ExecuteScalar

                            '   Case "2"
                            '      take_away.Show()
                            '     take_away.Focus()
                            '   take_away.income_id = "2"

                            '   Case "3"
                            '    tak_away2.Show()
                            '   tak_away2.Focus()
                            '   tak_away2.income_id = "3"

                            '   Case "4"
                            ' tak_away3.Show()
                            ' tak_away3.Focus()
                            ' tak_away3.income_id = "4"


                            '  Case "5"
                            '    tak_away4.Show()
                            '   tak_away4.Focus()
                            '   tak_away4.income_id = "5"



                            '  Case "6"
                            '      tak_away5.Show()
                            '     tak_away5.Focus()
                            '     tak_away5.income_id = "6"
                            ''
                    End Select

                Else
                    MessageBox.Show("user is not found")
                End If


        End Select
        myconnection.Close()

    End Sub




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        register.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        count = 0

    End Sub
    Private Sub GetIPAddress()




        strHostName = System.Net.Dns.GetHostName()

        strIPAddress = System.Net.Dns.GetHostByName(strHostName).AddressList(0)

        Dim hostName = System.Net.Dns.GetHostName()
        For Each hostAdr In System.Net.Dns.GetHostEntry(hostName).AddressList()
        Next

        MessageBox.Show("Host Name: " & strHostName & "; IP Address: " & strIPAddress.ToString)
        ''
        ' Get a list of serial port names.
        ports = {"8550", "5555", "9999", "8885"}

        ' Display each port name to the console.

        port = ports(i)

        i = i + 1



    End Sub
    Function connected(id As Integer, username As String)


        cmd = New SqlCommand("insert into online (id,name)values('" + id.ToString + "','" + username + "')", con)
        cmd.ExecuteNonQuery()
    End Function
End Class
