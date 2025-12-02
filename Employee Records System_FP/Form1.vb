Imports MySql.Data.MySqlClient
Imports System.Data
Public Class Form1

    Private conn As New MySqlConnection("server=localhost;userid=root;password=123456;database=employee_db;")
    Private selectedId As Integer = -1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvEmployees.AllowUserToAddRows = False
        dgvEmployees.ReadOnly = True
        LoadData()
    End Sub

    Private Sub LoadData()
        Try
            Dim sql As String = "SELECT id, name, position, salary, department FROM employees WHERE is_deleted = 0"
            Dim cmd As New MySqlCommand(sql, conn)
            Dim da As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)
            dgvEmployees.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message)
        End Try
    End Sub

    Private Sub ClearFields()
        txtName.Clear()
        txtPosition.Clear()
        txtSalary.Clear()
        txtDepartment.Clear()
        selectedId = -1
    End Sub

    Private Sub dgvEmployees_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmployees.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvEmployees.Rows(e.RowIndex)
            selectedId = Convert.ToInt32(row.Cells("id").Value)
            txtName.Text = row.Cells("name").Value.ToString()
            txtPosition.Text = row.Cells("position").Value.ToString()
            txtSalary.Text = row.Cells("salary").Value.ToString()
            txtDepartment.Text = row.Cells("department").Value.ToString()
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If String.IsNullOrWhiteSpace(txtName.Text) OrElse
           String.IsNullOrWhiteSpace(txtPosition.Text) OrElse
           String.IsNullOrWhiteSpace(txtSalary.Text) OrElse
           String.IsNullOrWhiteSpace(txtDepartment.Text) Then
            MessageBox.Show("Please fill all fields.")
            Return
        End If
        If Not Decimal.TryParse(txtSalary.Text, New Decimal()) Then
            MessageBox.Show("Salary must be a number.")
            Return
        End If
        Try
            Dim sql As String = "INSERT INTO employees (name, position, salary, department) VALUES (@n, @p, @s, @d)"
            Dim cmd As New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@n", txtName.Text.Trim())
            cmd.Parameters.AddWithValue("@p", txtPosition.Text.Trim())
            cmd.Parameters.AddWithValue("@s", Decimal.Parse(txtSalary.Text.Trim()))
            cmd.Parameters.AddWithValue("@d", txtDepartment.Text.Trim())
            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Employee added.")
            LoadData()
            ClearFields()
        Catch ex As Exception
            If conn.State = ConnectionState.Open Then conn.Close()
            MessageBox.Show("Add error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If selectedId = -1 Then
            MessageBox.Show("Select a record first.")
            Return
        End If
        If String.IsNullOrWhiteSpace(txtName.Text) OrElse
           String.IsNullOrWhiteSpace(txtPosition.Text) OrElse
           String.IsNullOrWhiteSpace(txtSalary.Text) OrElse
           String.IsNullOrWhiteSpace(txtDepartment.Text) Then
            MessageBox.Show("Please fill all fields.")
            Return
        End If
        If Not Decimal.TryParse(txtSalary.Text, New Decimal()) Then
            MessageBox.Show("Salary must be a number.")
            Return
        End If
        Try
            Dim sql As String = "UPDATE employees SET name=@n, position=@p, salary=@s, department=@d WHERE id=@id"
            Dim cmd As New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@n", txtName.Text.Trim())
            cmd.Parameters.AddWithValue("@p", txtPosition.Text.Trim())
            cmd.Parameters.AddWithValue("@s", Decimal.Parse(txtSalary.Text.Trim()))
            cmd.Parameters.AddWithValue("@d", txtDepartment.Text.Trim())
            cmd.Parameters.AddWithValue("@id", selectedId)
            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Employee updated.")
            LoadData()
            ClearFields()
        Catch ex As Exception
            If conn.State = ConnectionState.Open Then conn.Close()
            MessageBox.Show("Update error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If selectedId = -1 Then
            MessageBox.Show("Select a record first.")
            Return
        End If
        If MessageBox.Show("Are you sure you want to delete this record?", "Confirm", MessageBoxButtons.YesNo) = DialogResult.No Then
            Return
        End If
        Try
            Dim sql As String = "UPDATE employees SET is_deleted = 1 WHERE id=@id"
            Dim cmd As New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@id", selectedId)
            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Employee deleted.")
            LoadData()
            ClearFields()
        Catch ex As Exception
            If conn.State = ConnectionState.Open Then conn.Close()
            MessageBox.Show("Delete error: " & ex.Message)
        End Try
    End Sub
    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        LoadData()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFields()
    End Sub
End Class