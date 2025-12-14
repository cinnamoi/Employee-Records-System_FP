Imports MySql.Data.MySqlClient

Public Class Form1

    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDepartments()

        NumericUpDownSalary.Minimum = 0
        NumericUpDownSalary.Maximum = 1000000
        NumericUpDownSalary.DecimalPlaces = 0
    End Sub


    Private Sub LoadDepartments()
        ComboBoxDepartment.Items.Clear()
        ComboBoxDepartment.Items.Add("HR")
        ComboBoxDepartment.Items.Add("IT")
        ComboBoxDepartment.Items.Add("Finance")
        ComboBoxDepartment.Items.Add("Marketing")
        ComboBoxDepartment.Items.Add("Operations")

        ComboBoxDepartment.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub


    Private Sub ButtonConnect_Click(sender As Object, e As EventArgs) Handles ButtonConnect.Click
        conn = New MySqlConnection("server=localhost; userid=root; password=root; database=employee_records_system;")

        Try
            conn.Open()
            MessageBox.Show("Connected")
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub ButtonCreate_Click(sender As Object, e As EventArgs) Handles ButtonCreate.Click
        Dim query As String =
            "INSERT INTO employee_tbl (name, position, salary, department) 
             VALUES (@name, @position, @salary, @department);"

        Try
            Using conn As New MySqlConnection("server=localhost; userid=root; password=root; database=employee_records_system;")
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@name", TextBoxName.Text)
                    cmd.Parameters.AddWithValue("@position", TextBoxPosition.Text)
                    cmd.Parameters.AddWithValue("@salary", NumericUpDownSalary.Value)
                    cmd.Parameters.AddWithValue("@department", ComboBoxDepartment.Text)

                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Record inserted successfully!")
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub ButtonRead_Click(sender As Object, e As EventArgs) Handles ButtonRead.Click
        Dim query As String =
            "SELECT * FROM employee_tbl WHERE is_deleted = 0;"

        Try
            Using conn As New MySqlConnection("server=localhost; userid=root; password=root; database=employee_records_system;")
                Using adapter As New MySqlDataAdapter(query, conn)
                    Dim table As New DataTable()
                    adapter.Fill(table)

                    DataGridViewRecord.DataSource = table
                    DataGridViewRecord.Columns("id").Visible = False
                    DataGridViewRecord.Columns("is_deleted").Visible = False
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub DataGridViewRecord_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewRecord.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridViewRecord.Rows(e.RowIndex)

            TextBoxName.Text = row.Cells("name").Value.ToString()
            TextBoxPosition.Text = row.Cells("position").Value.ToString()
            NumericUpDownSalary.Value = Convert.ToDecimal(row.Cells("salary").Value)
            ComboBoxDepartment.Text = row.Cells("department").Value.ToString()
            TextBoxHiddenId.Text = row.Cells("id").Value.ToString()
        End If
    End Sub


    Private Sub ButtonUpdate_Click(sender As Object, e As EventArgs) Handles ButtonUpdate.Click
        Dim query As String =
            "UPDATE employee_tbl 
             SET name=@name, position=@position, salary=@salary, department=@department 
             WHERE id=@id;"

        Try
            Using conn As New MySqlConnection("server=localhost; userid=root; password=root; database=employee_records_system;")
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", CInt(TextBoxHiddenId.Text))
                    cmd.Parameters.AddWithValue("@name", TextBoxName.Text)
                    cmd.Parameters.AddWithValue("@position", TextBoxPosition.Text)
                    cmd.Parameters.AddWithValue("@salary", NumericUpDownSalary.Value)
                    cmd.Parameters.AddWithValue("@department", ComboBoxDepartment.Text)

                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Record updated successfully!")
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        Dim query As String =
            "UPDATE employee_tbl SET is_deleted = 1 WHERE id=@id;"

        Try
            Using conn As New MySqlConnection("server=localhost; userid=root; password=root; database=employee_records_system;")
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", CInt(TextBoxHiddenId.Text))
                    cmd.ExecuteNonQuery()

                    MessageBox.Show("Record deleted successfully!")

                    TextBoxName.Clear()
                    TextBoxPosition.Clear()
                    NumericUpDownSalary.Value = 0
                    ComboBoxDepartment.SelectedIndex = -1
                    TextBoxHiddenId.Clear()
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class
