
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class register2

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim id As String
        id = Val(register.id)
        Try




            con.ConnectionString = "Data Source = mayjor-pc;Initial Catalog=trade1;Integrated Security=True"
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "insert into accounts(id,name,addres,landmark,pincode,city,stat,phone)values('" + id + "','" + cuname_txt.Text + "','" + cuaddress_txt.Text + "','" + culandmark_txt.Text + "','" + cupincode_txt.Text + "','" + cucity_txt.Text + "','" + custate_txt.Text + "','" + cuphone_txt.Text + "')"
            cmd.ExecuteNonQuery()
            con.Close()

        Catch ex As Exception
            MessageBox.Show("error while inserting record in the table..." & ex.Message, "insert records")
        Finally
            con.Close()
            Me.Close()

        End Try

    End Sub
End Class