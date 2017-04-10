Option Explicit On
Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.IO
Imports System.Net.Sockets
Imports System.Environment




Public Class trades
    ''home tab
    Public host As String
    Public loc_addr As Net.IPAddress
    Public ip As Net.IPAddress
    Public port As String
    Public ports() As String
    Dim listener As New TcpListener(8888)
    Dim client As New TcpClient
    Dim i As Integer
    ''' 
    ''' '
    ''' 
    Public id As Integer
    Public myname As String
    Public cash As Decimal
    ''' 
    Dim trades_selected_args As EventArgs
    Dim trades_cell_entered As EventArgs
    Dim trades_selected_cell As EventArgs


    Private Sub trades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        login.Hide()
        'home tab

        listener.Start()

            Timer1.Start()
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand


        cash_lbl.Text = cash



        '''''''''''''''''''''''''''''




        'TODO: This line of code loads data into the 'Trade1DataSet.trades' table. You can move, or remove it, as needed.
        TradesTableAdapter.Fill(Me.Trade1DataSet.trades)
        'TODO: This line of code loads data into the 'Trade1DataSet.delivery' table. You can move, or remove it, as needed.
        Me.DeliveryTableAdapter.Fill(Me.Trade1DataSet.delivery)
        'TODO: This line of code loads data into the 'Trade1DataSet.stock' table. You can move, or remove it, as needed.
        Try
            Me.StockTableAdapter.Fill(Me.Trade1DataSet.stock)
        Catch ex As ConstraintException
        End Try







    End Sub
    ''             home  subs
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        'TODO: This line of code loads data into the 'Trade1DataSet1.online' table. You can move, or remove it, as needed.
        Me.OnlineTableAdapter1.Fill(Trade1DataSet11.online)



        Dim message As String
        Dim nstart, nlast As Integer
        If listener.Pending = True Then
            message = ""
            client = listener.AcceptTcpClient()
            Dim reader As New StreamReader(client.GetStream())
            While reader.Peek > -1
                message &= Convert.ToChar(reader.Read()).ToString
            End While
            If message.Contains("</>") Then
                nstart = InStr(message, "</>") + 4
                nlast = InStr(message, "<\>")
                message = Mid(message, nstart, nlast - nstart)
            End If
            chat.Text += myname & vbNewLine & message & vbNewLine


            chat.Select(Len(chat.Text), 0)
            chat.ScrollToCaret()
        End If
    End Sub
    Private Sub ok_btn_Click(sender As Object, e As EventArgs) Handles ok_btn.Click
        send_text()
    End Sub
    Private Sub send_txt_ENTER_KEY(sender As Object, e As KeyEventArgs) Handles send_txt.KeyDown
        If e.KeyCode = Keys.Enter Then
            send_text()
        End If
    End Sub
    Private Sub send_txt_Click(sender As Object, e As EventArgs) Handles send_txt.Click
        If send_txt.Text = "Enter your messages to chat" Then
            send_txt.Text = ""
        End If
    End Sub
    Function send_text()
        Try
            client = New TcpClient("127.0.0.1", 8888)
            Dim writer As New StreamWriter(client.GetStream())
            writer.Write(send_txt.Text & "<\>")
            writer.Flush()
            send_txt.Text = ""
            send_txt.Select()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

        End Try
    End Function

    Private Sub trades_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        listener.Stop()
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand




        Try
            'con.ConnectionString = "data source=MAYJOR-PC;initial catalog =prac1;persist security info=true;user id=; password="
            con.ConnectionString = "Data Source = mayjor-pc;Initial Catalog=trade1;Integrated Security=True"

            con.Open()
            cmd = New SqlCommand("delete from online where name='" + myname + "'", con)
            cmd.ExecuteNonQuery()
            con.Close()

        Catch ex As Exception
        End Try
    End Sub
    ''         end of  home  subs





    Private Sub direct_btn_Click(sender As Object, e As EventArgs)


    End Sub



    Private Sub TradesDataGridView_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles TradesDataGridView.CellContentClick
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        If e.ColumnIndex = 4 Then
            Dim serial As String = TradesDataGridView.Rows(e.RowIndex).Cells(0).Value
            MsgBox(serial)
            Dim v As Decimal = 0
            v = TradesDataGridView.Rows(e.RowIndex).Cells(3).Value
            MsgBox(v)
            Dim m As Decimal = 0
            m = TradesDataGridView.Rows(e.RowIndex).Cells(2).Value
            MsgBox(m)
            Dim x As Decimal = TradesDataGridView.Rows(e.RowIndex).Cells(6).Value


            If v > m And v < x And v <= cash Then
                Try
                    'con.ConnectionString = "data source=MAYJOR-PC;initial catalog =prac1;persist security info=true;user id=; password="
                    con.ConnectionString = "Data Source = mayjor-pc;Initial Catalog=trade1;Integrated Security=True"

                    con.Open()
                    cmd = New SqlCommand("update trades set overbid='" + v.ToString + "' where serial='" + serial.ToString + "'", con)
                    cmd.ExecuteNonQuery()
                    cmd = New SqlCommand("update trades set bidder='" + myname + "' where serial='" + serial.ToString + "'", con)
                    cmd.ExecuteNonQuery()
                    Dim mincash = cash - v
                    cmd = New SqlCommand("update useraccount set cash='" + mincash.ToString + "' where id='" + id.ToString + "'", con)
                    login.cash = mincash
                    cmd.ExecuteNonQuery()

                Catch ex As Exception

                Finally
                    TradesTableAdapter.Fill(Me.Trade1DataSet.trades)
                    MsgBox(v & myname & cash)

                    con.Close()
                End Try
            End If


        End If

        If e.ColumnIndex = 7 Then
            Dim serial As Integer = TradesDataGridView.Rows(e.RowIndex).Cells(0).Value
            MsgBox(serial)
            Dim v As Decimal = TradesDataGridView.Rows(e.RowIndex).Cells(6).Value
            MsgBox(v)


            If v <= cash Then
                Dim company As String = TradesDataGridView.Rows(e.RowIndex).Cells(1).Value
                Dim model As String = TradesDataGridView.Rows(e.RowIndex).Cells(8).Value
                Dim photo As Byte() = TradesDataGridView.Rows(e.RowIndex).Cells(9).Value
                Dim picture As PictureBox
                Dim disc As String = TradesDataGridView.Rows(e.RowIndex).Cells(10).Value
                Dim mani As String = TradesDataGridView.Rows(e.RowIndex).Cells(11).Value
                Dim color As String = TradesDataGridView.Rows(e.RowIndex).Cells(12).Value
                Dim timer = TradesDataGridView.Rows(e.RowIndex).Cells(14).Value

                Try
                    'con.ConnectionString = "data source=MAYJOR-PC;initial catalog =prac1;persist security info=True;user id=; password="
                    con.ConnectionString = "Data Source = mayjor-pc;Initial Catalog=trade1;Integrated Security=True"

                    con.Open()
                    cmd.Connection = con


                    cmd.CommandText = "insert into stock (id,serial,company,model,photo,description,manifactory,color,timer)values('" + id.ToString + "','" + serial.ToString + "','" + company + "','" + model + "',@photo,'" + disc + "','" + mani + "','" + color + "','" + timer.ToString + "')"



                    picture = pic_box2

                    Dim ms As New MemoryStream(photo)
                    Dim img As Image = System.Drawing.Image.FromStream(ms)
                    pic_box2.BackgroundImage = img
                    ms = New MemoryStream()
                    pic_box2.BackgroundImage.Save(ms, pic_box2.BackgroundImage.RawFormat)
                    Dim data As Byte() = ms.GetBuffer()
                    Dim p As New SqlParameter("@photo", SqlDbType.Image)
                    p.Value = data
                    cmd.Parameters.Add(p)

                    cmd.ExecuteNonQuery()
                    cmd.CommandText = "delete from trades where serial='" + serial.ToString + "'"
                    cmd.ExecuteNonQuery()
                    Dim mincash = cash - v
                    cmd = New SqlCommand("update useraccount set cash='" + mincash.ToString + "' where id='" + id.ToString + "'", con)
                    login.cash = mincash

                    cmd.ExecuteNonQuery()

                Catch ex As Exception
                    MsgBox("wrong" & ErrorToString())
                Finally

                    TradesTableAdapter.Fill(Me.Trade1DataSet.trades)
                    MsgBox(v & myname & cash)


                    'TODO: This line of code loads data into the 'Trade1DataSet.trades' table. You can move, or remove it, as needed.
                    TradesTableAdapter.Fill(Me.Trade1DataSet.trades)

                    con.Close()
                End Try
            End If


        End If
    End Sub



    Private Sub StockDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles StockDataGridView.CellContentClick
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        If e.ColumnIndex = 1 Then

            Dim serial As Integer = StockDataGridView.Rows(e.RowIndex).Cells(2).Value
            Dim company As String = StockDataGridView.Rows(e.RowIndex).Cells(3).Value
            Dim model As String = StockDataGridView.Rows(e.RowIndex).Cells(4).Value
            Dim timer = StockDataGridView.Rows(e.RowIndex).Cells(9).Value
            Dim statu As String = "requested"

            Try
                'con.ConnectionString = "data source=MAYJOR-PC;initial catalog =prac1;persist security info=True;user id=; password="
                con.ConnectionString = "Data Source = mayjor-pc;Initial Catalog=trade1;Integrated Security=True"
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "insert into delivery (id,owner,serial,company,model,timer,state)values('" + id.ToString + "','" + myname + "','" + serial.ToString + "','" + company + "','" + model + "','" + timer.ToString + "','" + statu + "')"

                cmd.ExecuteNonQuery()


                cmd.CommandText = "update stock set state='" + statu + "' where id='" + id.ToString + "'"
                cmd.ExecuteNonQuery()
            Catch ex As Exception

                MsgBox("wrong" & ErrorToString())
            Finally




                'TODO: This line of code loads data into the 'Trade1DataSet.delivery' table. You can move, or remove it, as needed.
                Me.DeliveryTableAdapter.Fill(Me.Trade1DataSet.delivery)
                'TODO: This line of code loads data into the 'Trade1DataSet.stock' table. You can move, or remove it, as needed.
                Me.StockTableAdapter.Fill(Me.Trade1DataSet.stock)
            End Try
        End If
    End Sub

    Private Sub TabPage3_Selected(sender As Object, e As TabControlEventArgs) Handles TabControl1.Selected
        'TODO: This line of code loads data into the 'Trade1DataSet.stock' table. You can move, or remove it, as needed.
        Me.StockTableAdapter.Fill(Me.Trade1DataSet.stock)
        'TODO: This line of code loads data into the 'Trade1DataSet.delivery' table. You can move, or remove it, as needed.
        Me.DeliveryTableAdapter.Fill(Me.Trade1DataSet.delivery)
    End Sub
    Private Sub TabPage1_Selected(sender As Object, e As TabControlEventArgs) Handles TabControl1.Selected
        'TODO: This line of code loads data into the 'Trade1DataSet.trades' table. You can move, or remove it, as needed.
        TradesTableAdapter.Fill(Me.Trade1DataSet.trades)
    End Sub
    Private Sub TabPage2_Selected(sender As Object, e As TabControlEventArgs) Handles TabControl1.Selected
        'TODO: This line of code loads data into the 'Trade1DataSet1.online' table. You can move, or remove it, as needed.
        Me.OnlineTableAdapter1.Fill(Trade1DataSet11.online)
    End Sub
    Private Sub btn_sell_Click(sender As Object, e As EventArgs) Handles btn_sell.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim picture As PictureBox

        picture = pic_box
        ' con.ConnectionString = "data source=MAYJOR-PC;initial catalog =trade1;persist security info=true;user id=; password="
        con.ConnectionString = "Data Source = mayjor-pc;Initial Catalog=trade1;Integrated Security=True"
        cmd.Connection = con
        con.Open()
        Try
            If comp_txt.Text = "" And mod_txt.Text = "" And disc_txt.Text = "" And made_txt.Text = "" And start_txt.Text = "" And dir_txt.Text = "" Then
                MsgBox("fill all fields")

            Else
                cmd = New SqlCommand("insert into trades (id,company,model,photo,description,manifactory,color,overbid,bidder,timer,lowercost,uppercost)values('" + id.ToString + "','" + comp_txt.Text + "','" + mod_txt.Text + "' ,@photo,'" + disc_txt.Text + "','" + made_txt.Text + "','" + color_txt.Text + "','" + start_txt.Text + "','" + "no bid" + "','" + "23:59:59" + "','" + start_txt.Text + "','" + dir_txt.Text + "')", con)



                Dim ms As New MemoryStream()
                pic_box.BackgroundImage.Save(ms, pic_box.BackgroundImage.RawFormat)
                Dim data As Byte() = ms.GetBuffer()
                Dim p As New SqlParameter("@photo", SqlDbType.Image)
                p.Value = data
                cmd.Parameters.Add(p)
                cmd.ExecuteNonQuery()
                MessageBox.Show("selling has been started", "save", MessageBoxButtons.OK)
            End If
        Catch Exception As NullReferenceException
            MsgBox("upload one photo")
        Finally


        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim browser As New OpenFileDialog

        If browser.ShowDialog() = Windows.Forms.DialogResult.OK Then
            pic_box.BackgroundImage =
                Image.FromFile(browser.FileName)
        End If

    End Sub

    Private Sub TradesDataGridView_CellMouseEnter(sender As Object, e As DataGridViewCellEventArgs) Handles TradesDataGridView.CellMouseEnter
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        trades_cell_entered = e
        If e.ColumnIndex = 1 Or e.ColumnIndex = 0 Or e.ColumnIndex = 2 Or e.ColumnIndex = 3 Or e.ColumnIndex = 4 Or e.ColumnIndex = 5 Or e.ColumnIndex = 6 Or e.ColumnIndex = 7 Or e.ColumnIndex = 8 Or e.ColumnIndex = 9 Or e.ColumnIndex = 10 Or e.ColumnIndex = 11 Or e.ColumnIndex = 12 Or e.ColumnIndex = 13 Or e.ColumnIndex = 14 Then

            Try
                'to show cash and time of every cell in $ labels 

                cash_lbl1.Text = TradesDataGridView.Rows(e.RowIndex).Cells(2).Value
                cash_lbl2.Text = TradesDataGridView.Rows(e.RowIndex).Cells(6).Value
                clock_lbl.Text = TradesDataGridView.Rows(e.RowIndex).Cells(14).Value.ToString

                '''''''''''''''''''''''''''

                Dim photo As Byte() = TradesDataGridView.Rows(e.RowIndex).Cells(9).Value
                Dim picture As PictureBox


                picture = pic_box2

                Dim ms As New MemoryStream(photo)
                Dim img As Image = System.Drawing.Image.FromStream(ms)
                pic_box2.BackgroundImage = img




            Catch ex As NullReferenceException
            Catch xx As ArgumentOutOfRangeException
            Catch cc As ArgumentNullException
            Catch sp As IndexOutOfRangeException
            Catch opoi As InvalidCastException

            Finally



            End Try

        End If


    End Sub

    Private Sub stockDataGridView_CellMouseEnter(sender As Object, e As DataGridViewCellEventArgs) Handles StockDataGridView.CellMouseEnter

        If e.ColumnIndex = 1 Or e.ColumnIndex = 0 Or e.ColumnIndex = 2 Or e.ColumnIndex = 3 Or e.ColumnIndex = 4 Or e.ColumnIndex = 5 Or e.ColumnIndex = 6 Or e.ColumnIndex = 7 Or e.ColumnIndex = 8 Or e.ColumnIndex = 9 Then


            Try
                Dim photo As Byte() = StockDataGridView.Rows(e.RowIndex).Cells(5).Value
                Dim picture As PictureBox


                picture = pic_box2

                Dim ms As New MemoryStream(photo)
                Dim img As Image = System.Drawing.Image.FromStream(ms)
                pic_box3.BackgroundImage = img




            Catch ex As NullReferenceException
            Catch xx As ArgumentOutOfRangeException
            Catch cc As ArgumentNullException
            Catch sp As IndexOutOfRangeException
            Catch opoi As InvalidCastException

            Finally



            End Try

        End If

    End Sub

    Private Sub TradesDataGridView_CellMouseSelected(sender As Object, e As DataGridViewCellMouseEventArgs) Handles TradesDataGridView.CellMouseClick

        show_info(e)

    End Sub



    Private Sub buy_btn_Click(sond As Object, oo As EventArgs) Handles buy_btn.Click
        directbuy(trades_selected_args)
        hide_info()
    End Sub
    Public Function directbuy(e As DataGridViewCellMouseEventArgs)
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        Dim serial As Integer = TradesDataGridView.Rows(e.RowIndex).Cells(0).Value

        Dim v As Decimal = TradesDataGridView.Rows(e.RowIndex).Cells(6).Value
        MsgBox(v)


        If v <= cash Then
            Dim company As String = TradesDataGridView.Rows(e.RowIndex).Cells(1).Value
            Dim model As String = TradesDataGridView.Rows(e.RowIndex).Cells(8).Value
            Dim photo As Byte() = TradesDataGridView.Rows(e.RowIndex).Cells(9).Value
            Dim picture As PictureBox
            Dim disc As String = TradesDataGridView.Rows(e.RowIndex).Cells(10).Value
            Dim mani As String = TradesDataGridView.Rows(e.RowIndex).Cells(11).Value
            Dim color As String = TradesDataGridView.Rows(e.RowIndex).Cells(12).Value
            Dim timer = TradesDataGridView.Rows(e.RowIndex).Cells(14).Value

            Try
                'con.ConnectionString = "data source=MAYJOR-PC;initial catalog =prac1;persist security info=True;user id=; password="
                con.ConnectionString = "Data Source = mayjor-pc;Initial Catalog=trade1;Integrated Security=True"

                con.Open()
                cmd.Connection = con


                cmd.CommandText = "insert into stock (id,serial,company,model,photo,description,manifactory,color,timer)values('" + id.ToString + "','" + serial.ToString + "','" + company + "','" + model + "',@photo,'" + disc + "','" + mani + "','" + color + "','" + timer.ToString + "')"



                picture = pic_box2

                Dim ms As New MemoryStream(photo)
                Dim img As Image = System.Drawing.Image.FromStream(ms)
                pic_box2.BackgroundImage = img
                ms = New MemoryStream()
                pic_box2.BackgroundImage.Save(ms, pic_box2.BackgroundImage.RawFormat)
                Dim data As Byte() = ms.GetBuffer()
                Dim p As New SqlParameter("@photo", SqlDbType.Image)
                p.Value = data
                cmd.Parameters.Add(p)

                cmd.ExecuteNonQuery()
                cmd.CommandText = "delete from trades where serial='" + serial.ToString + "'"
                cmd.ExecuteNonQuery()
                Dim mincash = cash - v
                cmd = New SqlCommand("update useraccount set cash='" + mincash.ToString + "' where id='" + id.ToString + "'", con)
                login.cash = mincash

                cmd.ExecuteNonQuery()

            Catch ex As Exception
                MsgBox("wrong" & ErrorToString())
            Finally

                TradesTableAdapter.Fill(Me.Trade1DataSet.trades)
                MsgBox(v & myname & cash)


                'TODO: This line of code loads data into the 'Trade1DataSet.trades' table. You can move, or remove it, as needed.
                TradesTableAdapter.Fill(Me.Trade1DataSet.trades)

                con.Close()
            End Try
        End If

    End Function

    Private Sub TradesDataGridView_MouseLeave(sender As Object, e As EventArgs) Handles TradesDataGridView.MouseLeave

        Dim l As DataGridViewCellMouseEventArgs = trades_selected_args
        show_info(l)



    End Sub

    Function show_info(e As DataGridViewCellMouseEventArgs)
        Try
            If e.ColumnIndex = 1 Or e.ColumnIndex = 0 Or e.ColumnIndex = 2 Or e.ColumnIndex = 3 Or e.ColumnIndex = 4 Or e.ColumnIndex = 5 Or e.ColumnIndex = 6 Or e.ColumnIndex = 7 Or e.ColumnIndex = 8 Or e.ColumnIndex = 9 Or e.ColumnIndex = 10 Or e.ColumnIndex = 11 Or e.ColumnIndex = 12 Or e.ColumnIndex = 13 Or e.ColumnIndex = 14 Then

                buy_btn.Visible = "true"
                add_btn.Visible = "true"
                TextBox1.Visible = "true"
                pic_box2.Visible = "true"
                cash_lbl1.Visible = "true"
                cash_lbl2.Visible = "true"
                Label10.Visible = "true"
                Label12.Visible = "true"
                trades_selected_args = e



                'to show cash and time of every cell in $ labels 

                cash_lbl1.Text = TradesDataGridView.Rows(e.RowIndex).Cells(2).Value
                cash_lbl2.Text = TradesDataGridView.Rows(e.RowIndex).Cells(6).Value
                clock_lbl.Text = TradesDataGridView.Rows(e.RowIndex).Cells(14).Value.ToString

                '''''''''''''''''''''''''''

                Dim photo As Byte() = TradesDataGridView.Rows(e.RowIndex).Cells(9).Value
                Dim picture As PictureBox


                picture = pic_box2

                Dim ms As New MemoryStream(photo)
                Dim img As Image = System.Drawing.Image.FromStream(ms)
                pic_box2.BackgroundImage = img



            End If
        Catch ex As NullReferenceException
        Catch xx As ArgumentOutOfRangeException
        Catch cc As ArgumentNullException
        Catch sp As IndexOutOfRangeException
        Catch opoi As InvalidCastException

        Finally



        End Try


    End Function

    Function addbid(e As DataGridViewCellMouseEventArgs)
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand


        Dim serial As String = TradesDataGridView.Rows(e.RowIndex).Cells(0).Value
        MsgBox(serial)
        Dim v As Decimal = 0
        v = TextBox1.Text
        MsgBox(v)
        Dim m As Decimal = 0
        m = TradesDataGridView.Rows(e.RowIndex).Cells(2).Value
        MsgBox(m)
        Dim x As Decimal = TradesDataGridView.Rows(e.RowIndex).Cells(6).Value


        If v > m And v < x And v <= cash Then
            Try
                'con.ConnectionString = "data source=MAYJOR-PC;initial catalog =prac1;persist security info=true;user id=; password="
                con.ConnectionString = "Data Source = mayjor-pc;Initial Catalog=trade1;Integrated Security=True"

                con.Open()
                cmd = New SqlCommand("update trades set overbid='" + v.ToString + "' where serial='" + serial.ToString + "'", con)
                cmd.ExecuteNonQuery()
                cmd = New SqlCommand("update trades set bidder='" + myname + "' where serial='" + serial.ToString + "'", con)
                cmd.ExecuteNonQuery()
                Dim mincash = cash - v
                cmd = New SqlCommand("update useraccount set cash='" + mincash.ToString + "' where id='" + id.ToString + "'", con)
                login.cash = mincash

                cmd.ExecuteNonQuery()

            Catch ex As Exception

            Finally
                TradesTableAdapter.Fill(Me.Trade1DataSet.trades)
                MsgBox(v & myname & cash)

                con.Close()
            End Try
        End If



    End Function

    Private Sub add_btn_Click(sender As Object, e As EventArgs) Handles add_btn.Click
        addbid(trades_selected_args)

    End Sub
    Function hide_info()
        buy_btn.Visible = "false"
        add_btn.Visible = "false"
        TextBox1.Visible = "false"
        pic_box2.Visible = "false"
        cash_lbl1.Visible = "false"
        cash_lbl2.Visible = "false"
        Label10.Visible = "false"
        Label12.Visible = "false"
    End Function


End Class

