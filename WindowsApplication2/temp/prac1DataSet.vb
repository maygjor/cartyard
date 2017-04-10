Partial Class prac1DataSet
    Partial Public Class informationDataTable
        Private Sub informationDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.nameColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class
End Class
