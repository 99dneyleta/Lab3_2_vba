Imports System.IO

Public Interface IMyInterface

    Sub printTableToFile(ByVal f As String)

    Function getElement(ByVal index As Byte) As String

    Sub readFromFileToArray(ByVal f As String)

    Sub addFromTableToArray(ByVal Name As String, ByVal v As Byte)

    ReadOnly Property count() As Integer

    ReadOnly Property Table() As DataTable

End Interface
Public Structure Pointt
    Public x As Integer
    Public y As Integer
    Public z As Integer
    Public name As String
    Public m As Double
End Structure
Public Class Point
    Implements IMyInterface
    Public arrayWithPoints(20) As Pointt

    Public Sub Add(ByVal el As Pointt)
        Dim flag As Boolean
        Dim i As Integer
        i = 0
        flag = False
        For Each element In arrayWithPoints
            If element.name = Nothing And flag = False Then
                arrayWithPoints(i) = el
                flag = True
            End If
            i = i + 1
        Next

    End Sub

    Public Sub addFromTableToArray(ByVal Name As String, ByVal v As Byte) Implements IMyInterface.addFromTableToArray
        Dim temp As Pointt
        temp.name = Start.DataGridView1.Rows(v).Cells(0).Value
        temp.x = Start.DataGridView1.Rows(v).Cells(1).Value
        temp.y = Start.DataGridView1.Rows(v).Cells(2).Value
        temp.z = Start.DataGridView1.Rows(v).Cells(3).Value
        temp.m = Start.DataGridView1.Rows(v).Cells(4).Value
        Me.Add(temp)
    End Sub

    Public Sub printArrayInTable()
        For i As Integer = 0 To Me.count - 1
            Start.DataGridView1.Rows.Add(arrayWithPoints(i).name, arrayWithPoints(i).x.ToString, arrayWithPoints(i).y.ToString, arrayWithPoints(i).z.ToString, arrayWithPoints(i).m.ToString)

        Next

    End Sub
    Public ReadOnly Property count As Integer Implements IMyInterface.count

        Get
            Dim countt As Integer
            count = 0

            For Each element In arrayWithPoints
                If element.name = Nothing Then
                    Return countt
                End If
                countt = countt + 1
            Next

            Return countt
        End Get
    End Property

    Public Function getElement(ByVal index As Byte) As String Implements IMyInterface.getElement
        Dim out As String
        If arrayWithPoints.Length < index Then
            MsgBox("value biggest then array length")
            Return out
        End If
        out = Me.arrayWithPoints(index).x.ToString + Me.arrayWithPoints(index).y.ToString + Me.arrayWithPoints(index).z.ToString + Me.arrayWithPoints(index).name + Me.arrayWithPoints(index).m.ToString
        Return out

    End Function

    Public Sub printTableToFile(ByVal f As String) Implements IMyInterface.printTableToFile
        Dim myFile As FileStream, textFile As StreamWriter
        myFile = New FileStream(f, FileMode.Create, FileAccess.Write)
        textFile = New StreamWriter(myFile)
        For i As Integer = 0 To Start.DataGridView1.RowCount - 2
            Dim temp As String
            For j As Integer = 0 To Start.DataGridView1.ColumnCount - 1
                temp = Start.DataGridView1.Rows(i).Cells(j).Value
                textFile.Write(temp)
                If Start.DataGridView1.ColumnCount - 1 <> j Then
                    textFile.Write("-")
                End If
            Next
            textFile.WriteLine("")
        Next
        textFile.Close()
    End Sub

    Public Sub readFromFileToArray(ByVal f As String) Implements IMyInterface.readFromFileToArray
        Dim myFile As FileStream
        Dim i As Integer
        i = 0
        myFile = New FileStream(f, FileMode.Open, FileAccess.Read)
        Dim textFile As StreamReader, s As String
        textFile = New StreamReader(myFile)
        s = textFile.ReadLine
        Do
            arrayWithPoints(i) = Parser(s)
            i = i + 1
            s = textFile.ReadLine
        Loop Until (s Is Nothing)

        myFile.Close()

    End Sub
    Public Function Parser(ByVal s As String)
        Dim ch As Char
        Dim currentPoint As Pointt
        Dim partLine As String
        ch = "-"
        partLine = Mid(s, 1, s.IndexOf(ch)) 'for x
        currentPoint.x = partLine
        s = Mid(s, partLine.Length + 2, s.Length - partLine.Length - 1)
        partLine = Mid(s, 1, s.IndexOf(ch)) 'for y
        currentPoint.y = partLine
        s = Mid(s, partLine.Length + 2, s.Length - partLine.Length - 1)
        partLine = Mid(s, 1, s.IndexOf(ch)) 'for z
        currentPoint.z = partLine
        s = Mid(s, partLine.Length + 2, s.Length - partLine.Length - 1)
        partLine = Mid(s, 1, s.IndexOf(ch)) 'for name
        currentPoint.name = partLine
        s = Mid(s, partLine.Length + 2, s.Length - partLine.Length - 1)
        partLine = s 'for 
        currentPoint.m = partLine

        Parser = currentPoint
    End Function
 
    Public ReadOnly Property Table As System.Data.DataTable Implements IMyInterface.Table
        Get
            Dim MyTable As New DataTable
            Dim row As DataRow
            MyTable.Columns.Add("Name")
            MyTable.Columns.Add("X")
            MyTable.Columns.Add("Y")
            MyTable.Columns.Add("Z")
            MyTable.Columns.Add("M")

            For i As Integer = 0 To Start.DataGridView1.RowCount - 2
                Dim temp As String
                    row("Name") = Start.DataGridView1.Rows(i).Cells(0).Value
                    row("X") = Start.DataGridView1.Rows(i).Cells(1).Value
                    row("Y") = Start.DataGridView1.Rows(i).Cells(2).Value
                    row("Z") = Start.DataGridView1.Rows(i).Cells(3).Value
                    row("M") = Start.DataGridView1.Rows(i).Cells(4).Value

                MyTable.Rows.Add(row)
            Next
            Return MyTable

        End Get
    End Property
End Class
