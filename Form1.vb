Public Class Form1
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        ListBox1.Items.Add("Redmi")
        Dim myItem
        myItem = InputBox("enter your fav phone")
        ListBox1.Items.Add("myItem")
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click

        Dim myItem2
        myItem2 = InputBox("Enter the name of phone to remove")

        ListBox1.Items.Remove(myItem2)
    End Sub

    Private Sub btnDeleteSelected_Click(sender As Object, e As EventArgs) Handles btnDeleteSelected.Click

        ListBox1.Items.Remove(ListBox1.SelectedItems)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ListBox1.Items.Clear()
    End Sub
End Class
