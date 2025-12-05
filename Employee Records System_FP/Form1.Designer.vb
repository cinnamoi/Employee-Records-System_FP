<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtPosition = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.dvgEmployees = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.numupdownSalary = New System.Windows.Forms.NumericUpDown()
        Me.cmbDepartment = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.btnRead = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.ButtonConnect = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        CType(Me.dvgEmployees, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numupdownSalary, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtPosition
        '
        Me.txtPosition.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtPosition.Location = New System.Drawing.Point(148, 87)
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.Size = New System.Drawing.Size(124, 20)
        Me.txtPosition.TabIndex = 0
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtName.Location = New System.Drawing.Point(148, 50)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(124, 20)
        Me.txtName.TabIndex = 2
        '
        'dvgEmployees
        '
        Me.dvgEmployees.BackgroundColor = System.Drawing.SystemColors.Info
        Me.dvgEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgEmployees.Location = New System.Drawing.Point(12, 184)
        Me.dvgEmployees.Name = "dvgEmployees"
        Me.dvgEmployees.Size = New System.Drawing.Size(401, 135)
        Me.dvgEmployees.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(104, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(95, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Position:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(77, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Department:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(103, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Salary:"
        '
        'numupdownSalary
        '
        Me.numupdownSalary.Location = New System.Drawing.Point(148, 124)
        Me.numupdownSalary.Name = "numupdownSalary"
        Me.numupdownSalary.Size = New System.Drawing.Size(120, 20)
        Me.numupdownSalary.TabIndex = 8
        '
        'cmbDepartment
        '
        Me.cmbDepartment.FormattingEnabled = True
        Me.cmbDepartment.Items.AddRange(New Object() {" marketing", " operations", "human resources", " finance"})
        Me.cmbDepartment.Location = New System.Drawing.Point(147, 157)
        Me.cmbDepartment.Name = "cmbDepartment"
        Me.cmbDepartment.Size = New System.Drawing.Size(121, 21)
        Me.cmbDepartment.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Label5.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(124, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(248, 19)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Employee Recording System"
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(32, 337)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(75, 23)
        Me.btnCreate.TabIndex = 11
        Me.btnCreate.Text = "Create"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'btnRead
        '
        Me.btnRead.Location = New System.Drawing.Point(128, 337)
        Me.btnRead.Name = "btnRead"
        Me.btnRead.Size = New System.Drawing.Size(75, 23)
        Me.btnRead.TabIndex = 12
        Me.btnRead.Text = "Read"
        Me.btnRead.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(228, 337)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 13
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(325, 337)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 14
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'ButtonConnect
        '
        Me.ButtonConnect.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ButtonConnect.Location = New System.Drawing.Point(419, 184)
        Me.ButtonConnect.Name = "ButtonConnect"
        Me.ButtonConnect.Size = New System.Drawing.Size(75, 135)
        Me.ButtonConnect.TabIndex = 16
        Me.ButtonConnect.Text = "Connect To My Sql"
        Me.ButtonConnect.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(419, 337)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(58, 23)
        Me.btnAdd.TabIndex = 17
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCyan
        Me.ClientSize = New System.Drawing.Size(506, 373)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.ButtonConnect)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnRead)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbDepartment)
        Me.Controls.Add(Me.numupdownSalary)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dvgEmployees)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtPosition)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dvgEmployees, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numupdownSalary, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPosition As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents dvgEmployees As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents numupdownSalary As NumericUpDown
    Friend WithEvents cmbDepartment As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnCreate As Button
    Friend WithEvents btnRead As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents ButtonConnect As Button
    Friend WithEvents btnAdd As Button
End Class
