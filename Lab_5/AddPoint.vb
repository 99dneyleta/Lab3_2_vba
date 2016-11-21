Public Class AddPoint

    
    


    Private Sub txtName_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtName.KeyPress
        If e.KeyChar = vbBack Then Exit Sub
        e.KeyChar = e.KeyChar.ToString.ToUpper
        If Not (e.KeyChar Like "[A-ZА-ЯЇІЄ’]") Then
            e.Handled = True
            Beep()
        End If
    End Sub
    Private Sub txtX_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtX.Validating
        If Not IsNumeric(txtX.Text) Then
            e.Cancel = True
            MsgBox("Set numeric data ")
        End If

    End Sub
    Private Sub txtY_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtY.Validating
        If Not IsNumeric(txtY.Text) Then
            e.Cancel = True
            MsgBox("Set numeric data ")
        End If

    End Sub

    Private Sub txtZ_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtZ.Validating
        If Not IsNumeric(txtZ.Text) Then
            e.Cancel = True
            MsgBox("Set numeric data ")
        End If

    End Sub
    Private Sub txtM_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtM.Validating
        If Not checkg() Then
            e.Cancel = True
            MsgBox("it's not kg")
        End If
        If Not checkDot() Then
            e.Cancel = True
            MsgBox("Only one dot EXAMPLE: 1.2kg")
        End If

    End Sub
    Private Function checkg()
        Dim l As String
        Dim N As String
        Dim flag As Boolean
        l = txtM.Text
        N = l.Length
        flag = False
        Dim temp As String
        temp = (l(N - 2) + l(N - 1)).ToString
        If (temp = "kg") Then
            flag = True

        End If
        Return flag
    End Function
    Private Function checkDot()
        Dim flg As Boolean
        Dim fl As Boolean
        Dim l As String
        l = txtM.Text
        flg = False
        fl = True
        For Each element In l
            If element = "." Then
                If flg = True Then
                    fl = False
                End If

                flg = True

            End If
        Next
        Return fl
    End Function


    Private Sub Form1_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyUp
        Dim txt As Control
        For Each txt In Controls
            If TypeOf txt Is TextBox Then
                If txt.Text.Trim = String.Empty Then
                    btnAdd.Enabled = False
                    Exit Sub
                End If
            End If
        Next
        btnAdd.Enabled = True
    End Sub

    Private Sub btnClear_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClear.Click
        Dim txt As Control
        For Each txt In Controls
            If TypeOf txt Is TextBox Then txt.Text = ""
        Next
        btnAdd.Enabled = False
    End Sub

    Private Sub cmdEnter_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAdd.Click
        Dim out As Pointt
        out.m = txtM.Text.ToString
        out.name = txtName.Text.ToString
        out.x = txtX.Text.ToString
        out.y = txtY.Text.ToString
        out.z = txtZ.Text.ToString
        'Start.DataGridView1.Rows.Add(txtName.Text.ToString, txtX.Text.ToString, txtY.Text.ToString, txtZ.Text.ToString, txtM.Text.ToString)
        Start.setArrE(out)
        MsgBox("Data was added")
        Me.Close()
    End Sub

    Private Sub AddPoint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtName.TextChanged

    End Sub
End Class

