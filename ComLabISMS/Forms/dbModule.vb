Imports MySql.Data.MySqlClient
Module dbModule

    Public con As MySqlConnection = myconn()
    Public Function myconn() As MySqlConnection
        Return New MySqlConnection("server=localhost;user id=root;password=;database=inventorydb; Convert Zero Datetime=True")
    End Function

    Dim result As Integer
    Dim cmd As New MySqlCommand
    Dim dReader As MySqlDataReader
    Dim da As New MySqlDataAdapter
    Dim dt As DataTable

    Public Function MyInsert(ByVal sql As String) As Boolean

        Try
            con.Open()

            With cmd
                .Connection = con
                .CommandText = sql
                result = .ExecuteNonQuery

            End With

            If result = 0 Then
                MsgBox("Error Inserting Data.")
            Else
                MsgBox("New Data Inserted!")
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)

        Finally

            con.Close()

        End Try

    End Function

    Public Sub MyLoad(ByVal obj As Object, ByVal CaseSwitch As String)

        Try
            con.Open()
            dReader = cmd.ExecuteReader()

            Select Case CaseSwitch

                Case "LoadBorRet"

                    Do While dReader.Read = True
                        obj.Rows.Add(dReader(0), dReader(1), dReader(2), dReader(3), dReader(4), dReader(5), dReader(6), dReader(7), dReader(8))
                    Loop
                Case "LoadBorRetFew"

                    Do While dReader.Read = True
                        obj.Rows.Add(dReader(0), dReader(1), dReader(2), dReader(8), dReader(9), dReader(10))
                    Loop

                Case "LoadInventory"

                    Do While dReader.Read = True
                        obj.Rows.Add(dReader(0), dReader(1), dReader(2), dReader(3), dReader(4), dReader(5))
                    Loop

                Case "LoadInv"

                    Do While dReader.Read = True
                        obj.Rows.Add(dReader(0), dReader(1), dReader(2), dReader(3), dReader(4), dReader(5), dReader(6))
                    Loop


                Case "LoadRepair"

                    Do While dReader.Read = True
                        obj.Rows.Add(dReader(0), dReader(1), dReader(2), dReader(3), dReader(4), dReader(5), dReader(6), dReader(7))
                    Loop

                Case "LoadBorrow"

                    Do While dReader.Read = True
                        obj.Rows.Add(dReader(0), dReader(1), dReader(2), dReader(3), dReader(4), dReader(5))
                    Loop

                Case "LoadDetails"

                    Do While dReader.Read = True
                        obj.Rows.Add(dReader(0), dReader(1), dReader(2), dReader(3), dReader(4), dReader(5), dReader(6))
                    Loop
                Case "LoadDetailsReport"

                    Do While dReader.Read = True
                        obj.Rows.Add(dReader(0), dReader(1), dReader(2), dReader(3), dReader(4), dReader(5), dReader(6), dReader(7))
                    Loop

                Case "LoadUsers"

                    Do While dReader.Read = True
                        obj.Rows.Add(dReader(0), dReader(1), dReader(2), dReader(3), dReader(4), dReader(5))
                    Loop

                Case "LoadItems"

                    Do While dReader.Read = True
                        obj.Rows.Add(dReader(2), dReader(0), dReader(1), dReader(3), dReader(4), dReader(5))
                    Loop

                Case "LoadComInv"

                    Do While dReader.Read = True
                        obj.Rows.Add(dReader(0), dReader(1), dReader(2), dReader(3), dReader(4), dReader(5), dReader(6), dReader(7), dReader(8), dReader(9))
                    Loop


            End Select

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            da.Dispose()
            con.Close()
        End Try

    End Sub

    Public Sub SelectAll(ByVal sql As String)
        Try
            con.Open()
            With cmd
                .Connection = con
                .CommandText = sql
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            da.Dispose()
            con.Close()
        End Try
    End Sub

    Public Function MyUpdate(ByVal sql As String) As Boolean

        Try
            con.Open()

            With cmd
                .Connection = con
                .CommandText = sql
                result = .ExecuteNonQuery

            End With

            If result = 0 Then
                Return False
            Else
                Return True
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)

        Finally

            con.Close()

        End Try

    End Function

    Public Function MyDelete(ByVal sql As String) As Boolean

        Try
            con.Open()

            With cmd
                .Connection = con
                .CommandText = sql
                result = .ExecuteNonQuery

            End With

            If result = 0 Then
                Return False
            Else
                Return True
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)

        Finally

            con.Close()

        End Try


    End Function

    Public Sub ClearTextBoxes(ByVal frm As Control)

        For Each Control In frm.Controls
            If TypeOf Control Is TextBox Then
                Control.Text = ""     'Clear all text
            End If
        Next Control

    End Sub


    'Private Sub AutoNumberNo()
    '    Dim myReader As SqlDataReader
    '    con = GetConnect()
    '    con.Open()
    '    Dim temp As String
    '    Try
    '        Dim sql As String = "SELECT MAX(NO) 'IDNumber' FROM Student "
    '        Dim comm As SqlCommand = New SqlCommand(Sql, conn)
    '        dReader = comm.ExecuteReader
    '        If dReader.HasRows Then
    '            While dReader.Read()
    '                temp = dReader.Item("IDNumber") + 1
    '            End While
    '        End If
    '        dReader.Close()
    '    Catch ex As Exception

    '    End Try
    '    con.Close()
    '    txtId.Text = String.Concat(temp) ' result will appear in textbox txtId
    'End Sub


End Module
