Public Class frmMngrQuiz
    Private Sub MathBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MathBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MathBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MathquizDataSet)

    End Sub

    Private Sub frmMngrQuiz_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MathquizDataSet.Math' table. You can move, or remove it, as needed.
        Me.MathTableAdapter.Fill(Me.MathquizDataSet.Math)

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            MathBindingNavigatorSaveItem.PerformClick()
            MsgBox("Successfully saved and updated!", MsgBoxStyle.Information, "Saved")
        Catch ex As Exception
            MsgBox("Update denied! Program need to restart." & vbCrLf & "Program will restart now and please try to update again.", MsgBoxStyle.Exclamation, "Restart required")
            Application.Restart()
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        BindingNavigatorAddNewItem.PerformClick()
        IDTextBox.Text = MathDataGridView.Rows(MathDataGridView.RowCount - 2).Cells(0).Value + 1
        ATextBox.Text = "A. "
        BTextBox.Text = "B. "
        CTextBox.Text = "C. "
        DTextBox.Text = "D. "
        QuizTextBox.Focus()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MsgBox("Are you sure you want to permanently delete this item?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Warning") = MsgBoxResult.Yes Then
            BindingNavigatorDeleteItem.PerformClick()
            MsgBox("Item deleted", MsgBoxStyle.Information, "Deleted")
        End If

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub
End Class