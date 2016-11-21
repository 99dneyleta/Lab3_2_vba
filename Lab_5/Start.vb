Imports System.IO

Public Class Start
    Dim p As New Point

    Private Sub btnAddElRoArr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AddPoint.Show()
    End Sub

    Private Sub btnWriteToFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWriteToFile.Click
        Dim f As String
        f = "C:\Users\progr\Desktop\Lab5_vba-master\output.txt"
        p.printTableToFile(f)


    End Sub

    Private Sub btnReadFromFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReadFromFile.Click
        Dim a As String = "C:\Users\progr\Desktop\Lab5_vba-master\input.txt"

        
        p.readFromFileToArray(a)
    End Sub
    Public Function readByFile(ByVal n As Integer)
       
    End Function
    

    Private Sub Start_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


    End Sub

    Private Sub btnAddToArray_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddToArray.Click
        AddPoint.Show()
    End Sub

    Public Sub setArrE(ByVal el As Pointt)
        p.Add(el)


    End Sub




    Private Sub btnShowArray_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowArray.Click
        p.printArrayInTable()
    End Sub

    Private Sub btnGetElFromArr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetElFromArr.Click
        Dim i As Integer
        Dim temp As Pointt
        i = Me.DataGridView1.SelectedRows.Count
        temp.name = Me.DataGridView1.Rows(i).Cells(0).Value
        p.addFromTableToArray(temp.name, Me.DataGridView1.CurrentCell.RowIndex)
    End Sub
End Class
