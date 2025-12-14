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
        Me.TextBoxPosition = New System.Windows.Forms.TextBox()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.DataGridViewRecord = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NumericUpDownSalary = New System.Windows.Forms.NumericUpDown()
        Me.ComboBoxDepartment = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ButtonCreate = New System.Windows.Forms.Button()
        Me.ButtonRead = New System.Windows.Forms.Button()
        Me.ButtonUpdate = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.ButtonConnect = New System.Windows.Forms.Button()
        Me.TextBoxHiddenId = New System.Windows.Forms.TextBox()
        CType(Me.DataGridViewRecord, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownSalary, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBoxPosition
        '
        Me.TextBoxPosition.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TextBoxPosition.Location = New System.Drawing.Point(88, 101)
        Me.TextBoxPosition.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxPosition.Name = "TextBoxPosition"
        Me.TextBoxPosition.Size = New System.Drawing.Size(164, 22)
        Me.TextBoxPosition.TabIndex = 0
        '
        'TextBoxName
        '
        Me.TextBoxName.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TextBoxName.Location = New System.Drawing.Point(88, 66)
        Me.TextBoxName.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(164, 22)
        Me.TextBoxName.TabIndex = 2
        '
        'DataGridViewRecord
        '
        Me.DataGridViewRecord.BackgroundColor = System.Drawing.SystemColors.Info
        Me.DataGridViewRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewRecord.Location = New System.Drawing.Point(25, 145)
        Me.DataGridViewRecord.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridViewRecord.Name = "DataGridViewRecord"
        Me.DataGridViewRecord.RowHeadersWidth = 51
        Me.DataGridViewRecord.Size = New System.Drawing.Size(489, 166)
        Me.DataGridViewRecord.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 72)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 107)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Position:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(263, 104)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Department:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(294, 72)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Salary:"
        '
        'NumericUpDownSalary
        '
        Me.NumericUpDownSalary.Location = New System.Drawing.Point(351, 67)
        Me.NumericUpDownSalary.Margin = New System.Windows.Forms.Padding(4)
        Me.NumericUpDownSalary.Name = "NumericUpDownSalary"
        Me.NumericUpDownSalary.Size = New System.Drawing.Size(160, 22)
        Me.NumericUpDownSalary.TabIndex = 8
        '
        'ComboBoxDepartment
        '
        Me.ComboBoxDepartment.FormattingEnabled = True
        Me.ComboBoxDepartment.Items.AddRange(New Object() {" marketing", " operations", "human resources", " finance"})
        Me.ComboBoxDepartment.Location = New System.Drawing.Point(351, 101)
        Me.ComboBoxDepartment.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBoxDepartment.Name = "ComboBoxDepartment"
        Me.ComboBoxDepartment.Size = New System.Drawing.Size(160, 24)
        Me.ComboBoxDepartment.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Label5.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(152, 20)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(304, 25)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Employee Recording System"
        '
        'ButtonCreate
        '
        Me.ButtonCreate.Location = New System.Drawing.Point(104, 326)
        Me.ButtonCreate.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonCreate.Name = "ButtonCreate"
        Me.ButtonCreate.Size = New System.Drawing.Size(124, 50)
        Me.ButtonCreate.TabIndex = 11
        Me.ButtonCreate.Text = "Create"
        Me.ButtonCreate.UseVisualStyleBackColor = True
        '
        'ButtonRead
        '
        Me.ButtonRead.Location = New System.Drawing.Point(104, 384)
        Me.ButtonRead.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonRead.Name = "ButtonRead"
        Me.ButtonRead.Size = New System.Drawing.Size(125, 44)
        Me.ButtonRead.TabIndex = 12
        Me.ButtonRead.Text = "Read"
        Me.ButtonRead.UseVisualStyleBackColor = True
        '
        'ButtonUpdate
        '
        Me.ButtonUpdate.Location = New System.Drawing.Point(331, 326)
        Me.ButtonUpdate.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonUpdate.Name = "ButtonUpdate"
        Me.ButtonUpdate.Size = New System.Drawing.Size(125, 48)
        Me.ButtonUpdate.TabIndex = 13
        Me.ButtonUpdate.Text = "Update"
        Me.ButtonUpdate.UseVisualStyleBackColor = True
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Location = New System.Drawing.Point(331, 382)
        Me.ButtonDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(125, 46)
        Me.ButtonDelete.TabIndex = 14
        Me.ButtonDelete.Text = "Delete"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'ButtonConnect
        '
        Me.ButtonConnect.Location = New System.Drawing.Point(547, 145)
        Me.ButtonConnect.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonConnect.Name = "ButtonConnect"
        Me.ButtonConnect.Size = New System.Drawing.Size(98, 166)
        Me.ButtonConnect.TabIndex = 17
        Me.ButtonConnect.Text = "Connect"
        Me.ButtonConnect.UseVisualStyleBackColor = True
        '
        'TextBoxHiddenId
        '
        Me.TextBoxHiddenId.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TextBoxHiddenId.Location = New System.Drawing.Point(557, 66)
        Me.TextBoxHiddenId.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxHiddenId.Name = "TextBoxHiddenId"
        Me.TextBoxHiddenId.Size = New System.Drawing.Size(88, 22)
        Me.TextBoxHiddenId.TabIndex = 18
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MintCream
        Me.ClientSize = New System.Drawing.Size(675, 459)
        Me.Controls.Add(Me.TextBoxHiddenId)
        Me.Controls.Add(Me.ButtonConnect)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.ButtonUpdate)
        Me.Controls.Add(Me.ButtonRead)
        Me.Controls.Add(Me.ButtonCreate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ComboBoxDepartment)
        Me.Controls.Add(Me.NumericUpDownSalary)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridViewRecord)
        Me.Controls.Add(Me.TextBoxName)
        Me.Controls.Add(Me.TextBoxPosition)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridViewRecord, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownSalary, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxPosition As TextBox
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents DataGridViewRecord As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents NumericUpDownSalary As NumericUpDown
    Friend WithEvents ComboBoxDepartment As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ButtonCreate As Button
    Friend WithEvents ButtonRead As Button
    Friend WithEvents ButtonUpdate As Button
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents ButtonConnect As Button
    Friend WithEvents TextBoxHiddenId As TextBox
End Class
