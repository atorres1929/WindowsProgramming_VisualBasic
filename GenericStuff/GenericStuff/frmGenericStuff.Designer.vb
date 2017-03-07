<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGenericStuff
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
        Me.components = New System.ComponentModel.Container()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.lblBirthday = New System.Windows.Forms.Label()
        Me.lblNumericGrade = New System.Windows.Forms.Label()
        Me.Senior = New System.Windows.Forms.Label()
        Me.lblLetterGrade = New System.Windows.Forms.Label()
        Me.chkSenior = New System.Windows.Forms.CheckBox()
        Me.cboGrade = New System.Windows.Forms.ComboBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.txtNumericGrade = New System.Windows.Forms.TextBox()
        Me.btnAction = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.mskBirthday = New System.Windows.Forms.MaskedTextBox()
        Me.errP = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.errP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(44, 34)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(35, 13)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name"
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Location = New System.Drawing.Point(44, 75)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(26, 13)
        Me.lblAge.TabIndex = 1
        Me.lblAge.Text = "Age"
        '
        'lblBirthday
        '
        Me.lblBirthday.AutoSize = True
        Me.lblBirthday.Location = New System.Drawing.Point(44, 124)
        Me.lblBirthday.Name = "lblBirthday"
        Me.lblBirthday.Size = New System.Drawing.Size(45, 13)
        Me.lblBirthday.TabIndex = 2
        Me.lblBirthday.Text = "Birthday"
        '
        'lblNumericGrade
        '
        Me.lblNumericGrade.AutoSize = True
        Me.lblNumericGrade.Location = New System.Drawing.Point(44, 173)
        Me.lblNumericGrade.Name = "lblNumericGrade"
        Me.lblNumericGrade.Size = New System.Drawing.Size(78, 13)
        Me.lblNumericGrade.TabIndex = 3
        Me.lblNumericGrade.Text = "Numeric Grade"
        '
        'Senior
        '
        Me.Senior.AutoSize = True
        Me.Senior.Location = New System.Drawing.Point(44, 218)
        Me.Senior.Name = "Senior"
        Me.Senior.Size = New System.Drawing.Size(37, 13)
        Me.Senior.TabIndex = 4
        Me.Senior.Text = "Senior"
        '
        'lblLetterGrade
        '
        Me.lblLetterGrade.AutoSize = True
        Me.lblLetterGrade.Location = New System.Drawing.Point(42, 267)
        Me.lblLetterGrade.Name = "lblLetterGrade"
        Me.lblLetterGrade.Size = New System.Drawing.Size(66, 13)
        Me.lblLetterGrade.TabIndex = 5
        Me.lblLetterGrade.Text = "Letter Grade"
        '
        'chkSenior
        '
        Me.chkSenior.AutoSize = True
        Me.chkSenior.Location = New System.Drawing.Point(152, 218)
        Me.chkSenior.Name = "chkSenior"
        Me.chkSenior.Size = New System.Drawing.Size(15, 14)
        Me.chkSenior.TabIndex = 4
        Me.chkSenior.UseVisualStyleBackColor = True
        '
        'cboGrade
        '
        Me.cboGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGrade.FormattingEnabled = True
        Me.cboGrade.Location = New System.Drawing.Point(152, 259)
        Me.cboGrade.Name = "cboGrade"
        Me.cboGrade.Size = New System.Drawing.Size(121, 21)
        Me.cboGrade.TabIndex = 5
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(152, 31)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(143, 20)
        Me.txtName.TabIndex = 0
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(152, 75)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(143, 20)
        Me.txtAge.TabIndex = 1
        Me.txtAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNumericGrade
        '
        Me.txtNumericGrade.Location = New System.Drawing.Point(152, 170)
        Me.txtNumericGrade.Name = "txtNumericGrade"
        Me.txtNumericGrade.Size = New System.Drawing.Size(143, 20)
        Me.txtNumericGrade.TabIndex = 3
        Me.txtNumericGrade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnAction
        '
        Me.btnAction.Location = New System.Drawing.Point(47, 343)
        Me.btnAction.Name = "btnAction"
        Me.btnAction.Size = New System.Drawing.Size(75, 23)
        Me.btnAction.TabIndex = 6
        Me.btnAction.Text = "Action"
        Me.btnAction.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(220, 343)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(412, 343)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'mskBirthday
        '
        Me.mskBirthday.Location = New System.Drawing.Point(152, 121)
        Me.mskBirthday.Mask = "00/00/0000"
        Me.mskBirthday.Name = "mskBirthday"
        Me.mskBirthday.Size = New System.Drawing.Size(143, 20)
        Me.mskBirthday.TabIndex = 2
        Me.mskBirthday.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.mskBirthday.ValidatingType = GetType(Date)
        '
        'errP
        '
        Me.errP.ContainerControl = Me
        '
        'frmGenericStuff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(627, 395)
        Me.Controls.Add(Me.mskBirthday)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnAction)
        Me.Controls.Add(Me.txtNumericGrade)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.cboGrade)
        Me.Controls.Add(Me.chkSenior)
        Me.Controls.Add(Me.lblLetterGrade)
        Me.Controls.Add(Me.Senior)
        Me.Controls.Add(Me.lblNumericGrade)
        Me.Controls.Add(Me.lblBirthday)
        Me.Controls.Add(Me.lblAge)
        Me.Controls.Add(Me.lblName)
        Me.Name = "frmGenericStuff"
        Me.Text = "Form1"
        CType(Me.errP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents lblAge As Label
    Friend WithEvents lblBirthday As Label
    Friend WithEvents lblNumericGrade As Label
    Friend WithEvents Senior As Label
    Friend WithEvents lblLetterGrade As Label
    Friend WithEvents chkSenior As CheckBox
    Friend WithEvents cboGrade As ComboBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents txtNumericGrade As TextBox
    Friend WithEvents btnAction As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents mskBirthday As MaskedTextBox
    Friend WithEvents errP As ErrorProvider
End Class
