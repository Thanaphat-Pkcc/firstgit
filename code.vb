Imports System.Data.Sql
Imports System.Data.SqlClient

Module code
    'ฐานข้อมูล
    Friend cn As New SqlConnection("Data source=DESKTOP-LDH5UV8\SQLEXPRESS ;Initial Catalog=coffeeshop ;Integrated Security=SSPI;")
    Friend cmd As New SqlCommand
    Friend DA As New SqlDataAdapter
    Friend DS As New DataSet
    Friend DR As SqlDataReader
    Friend sql As String = ""



    Friend Sub connect()
        Try
            If cn.State = ConnectionState.Closed Then cn.Open()
        Catch ex As Exception
            MsgBox("ไม่สามารถเชื่อมต่อฐานข้อมูลได้")
        End Try

    End Sub

    Friend Function cmd_excuteNonquery()
        connect()
        cmd = New SqlCommand(sql, cn)
        Return cmd.ExecuteNonQuery()
    End Function

    Friend Function cmd_excuteScalar()
        connect()
        cmd = New SqlCommand(sql, cn)
        Return cmd.ExecuteScalar()
    End Function



    Friend Function cmd_excuteToDataTable()
        connect()
        DA = New SqlDataAdapter(sql, cn)
        DS = New DataSet
        DA.Fill(DS, "table")
        Return DS.Tables("table")
    End Function


    Friend Function confirm(your_text As String, Optional your_title As String = "Confirm ?") As DialogResult
        Return MsgBox(your_text, vbQuestion + vbYesNo, your_title)
    End Function

    Public Sub Load_Sale_item(ByVal imagelist_name As ImageList, ByVal listview_name As ListView, ByVal datatable_query As DataTable, ByVal image_defult As Image, ByVal columnName_ID_Product As String, ByVal columnName_Name_product As String)
        Dim amount_row As Integer = datatable_query.Rows.Count - 1
        imagelist_name.Images.Clear()
        listview_name.Items.Clear()
        For idx As Integer = 0 To amount_row
            imagelist_name.Images.Add(image_defult)
            Dim name_picture As String = datatable_query.Rows(idx)(columnName_ID_Product) & " | " & datatable_query.Rows(idx)(columnName_Name_product)
            listview_name.Items.Add(name_picture, idx)
            listview_name.Refresh()
        Next
    End Sub





    Friend Function Sum_Column_Currency(ByVal listview_name As ListView, ByVal Index_column As Integer)
        Dim result As Double = 0
        Dim i As Integer = listview_name.Items.Count - 1
        For j As Integer = 0 To i
            result += CType(listview_name.Items(j).SubItems(Index_column).Text, Double)
        Next
        Return FormatNumber(result)
    End Function


End Module