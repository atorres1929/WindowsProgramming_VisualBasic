<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.grpAdd = New System.Windows.Forms.GroupBox()
        Me.btnClearAdd = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblAlt = New System.Windows.Forms.Label()
        Me.dtmEndAdd = New System.Windows.Forms.DateTimePicker()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.lstOp = New System.Windows.Forms.ListBox()
        Me.lstIntervalAdd = New System.Windows.Forms.ListBox()
        Me.dtmStartAdd = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpSpan = New System.Windows.Forms.GroupBox()
        Me.btnClearSpan = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnCalculateSpan = New System.Windows.Forms.Button()
        Me.txtElapsed = New System.Windows.Forms.TextBox()
        Me.lstIntervalSpan = New System.Windows.Forms.ListBox()
        Me.dtmEndSpan = New System.Windows.Forms.DateTimePicker()
        Me.dtmStartSpan = New System.Windows.Forms.DateTimePicker()
        Me.lblElapsedTime = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.errP = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.grpAdd.SuspendLayout()
        Me.grpSpan.SuspendLayout()
        CType(Me.errP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpAdd
        '
        Me.grpAdd.Controls.Add(Me.btnClearAdd)
        Me.grpAdd.Controls.Add(Me.btnAdd)
        Me.grpAdd.Controls.Add(Me.lblAlt)
        Me.grpAdd.Controls.Add(Me.dtmEndAdd)
        Me.grpAdd.Controls.Add(Me.lblResult)
        Me.grpAdd.Controls.Add(Me.txtQty)
        Me.grpAdd.Controls.Add(Me.lstOp)
        Me.grpAdd.Controls.Add(Me.lstIntervalAdd)
        Me.grpAdd.Controls.Add(Me.dtmStartAdd)
        Me.grpAdd.Controls.Add(Me.Label7)
        Me.grpAdd.Controls.Add(Me.Label6)
        Me.grpAdd.Controls.Add(Me.Label5)
        Me.grpAdd.Controls.Add(Me.Label4)
        Me.grpAdd.Controls.Add(Me.Label3)
        Me.grpAdd.Controls.Add(Me.Label2)
        Me.grpAdd.Controls.Add(Me.Label1)
        Me.grpAdd.Location = New System.Drawing.Point(21, 27)
        Me.grpAdd.Name = "grpAdd"
        Me.grpAdd.Size = New System.Drawing.Size(371, 417)
        Me.grpAdd.TabIndex = 0
        Me.grpAdd.TabStop = False
        Me.grpAdd.Text = "Adding and Subtracting Dates"
        '
        'btnClearAdd
        '
        Me.btnClearAdd.Location = New System.Drawing.Point(261, 350)
        Me.btnClearAdd.Name = "btnClearAdd"
        Me.btnClearAdd.Size = New System.Drawing.Size(91, 30)
        Me.btnClearAdd.TabIndex = 15
        Me.btnClearAdd.Text = "Clear"
        Me.btnClearAdd.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(261, 302)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(91, 30)
        Me.btnAdd.TabIndex = 14
        Me.btnAdd.Text = "Process"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lblAlt
        '
        Me.lblAlt.BackColor = System.Drawing.Color.White
        Me.lblAlt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAlt.Location = New System.Drawing.Point(129, 349)
        Me.lblAlt.Name = "lblAlt"
        Me.lblAlt.Size = New System.Drawing.Size(107, 24)
        Me.lblAlt.TabIndex = 13
        '
        'dtmEndAdd
        '
        Me.dtmEndAdd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtmEndAdd.Location = New System.Drawing.Point(129, 305)
        Me.dtmEndAdd.Name = "dtmEndAdd"
        Me.dtmEndAdd.Size = New System.Drawing.Size(106, 20)
        Me.dtmEndAdd.TabIndex = 12
        '
        'lblResult
        '
        Me.lblResult.BackColor = System.Drawing.Color.White
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblResult.Location = New System.Drawing.Point(129, 261)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(106, 24)
        Me.lblResult.TabIndex = 11
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(129, 220)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(106, 20)
        Me.txtQty.TabIndex = 10
        '
        'lstOp
        '
        Me.lstOp.FormattingEnabled = True
        Me.lstOp.Location = New System.Drawing.Point(130, 150)
        Me.lstOp.Name = "lstOp"
        Me.lstOp.Size = New System.Drawing.Size(105, 43)
        Me.lstOp.TabIndex = 9
        '
        'lstIntervalAdd
        '
        Me.lstIntervalAdd.FormattingEnabled = True
        Me.lstIntervalAdd.Location = New System.Drawing.Point(129, 82)
        Me.lstIntervalAdd.Name = "lstIntervalAdd"
        Me.lstIntervalAdd.Size = New System.Drawing.Size(106, 56)
        Me.lstIntervalAdd.TabIndex = 8
        '
        'dtmStartAdd
        '
        Me.dtmStartAdd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtmStartAdd.Location = New System.Drawing.Point(131, 44)
        Me.dtmStartAdd.Name = "dtmStartAdd"
        Me.dtmStartAdd.Size = New System.Drawing.Size(105, 20)
        Me.dtmStartAdd.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(24, 350)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Alternate Format"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 311)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "DTM Resuilt"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 262)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "String result"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 223)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "How much?"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Add or Subtract?"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "What interval?"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Start Date"
        '
        'grpSpan
        '
        Me.grpSpan.Controls.Add(Me.btnClearSpan)
        Me.grpSpan.Controls.Add(Me.btnUpdate)
        Me.grpSpan.Controls.Add(Me.btnCalculateSpan)
        Me.grpSpan.Controls.Add(Me.txtElapsed)
        Me.grpSpan.Controls.Add(Me.lstIntervalSpan)
        Me.grpSpan.Controls.Add(Me.dtmEndSpan)
        Me.grpSpan.Controls.Add(Me.dtmStartSpan)
        Me.grpSpan.Controls.Add(Me.lblElapsedTime)
        Me.grpSpan.Controls.Add(Me.Label10)
        Me.grpSpan.Controls.Add(Me.Label9)
        Me.grpSpan.Controls.Add(Me.Label8)
        Me.grpSpan.Location = New System.Drawing.Point(448, 27)
        Me.grpSpan.Name = "grpSpan"
        Me.grpSpan.Size = New System.Drawing.Size(306, 417)
        Me.grpSpan.TabIndex = 1
        Me.grpSpan.TabStop = False
        Me.grpSpan.Text = "Determining the Interval"
        '
        'btnClearSpan
        '
        Me.btnClearSpan.Location = New System.Drawing.Point(216, 345)
        Me.btnClearSpan.Name = "btnClearSpan"
        Me.btnClearSpan.Size = New System.Drawing.Size(79, 35)
        Me.btnClearSpan.TabIndex = 10
        Me.btnClearSpan.Text = "Clear"
        Me.btnClearSpan.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(117, 345)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(79, 35)
        Me.btnUpdate.TabIndex = 9
        Me.btnUpdate.Text = "Update Start from End"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnCalculateSpan
        '
        Me.btnCalculateSpan.Location = New System.Drawing.Point(9, 345)
        Me.btnCalculateSpan.Name = "btnCalculateSpan"
        Me.btnCalculateSpan.Size = New System.Drawing.Size(79, 35)
        Me.btnCalculateSpan.TabIndex = 8
        Me.btnCalculateSpan.Text = "Calculate Span"
        Me.btnCalculateSpan.UseVisualStyleBackColor = True
        '
        'txtElapsed
        '
        Me.txtElapsed.Location = New System.Drawing.Point(99, 289)
        Me.txtElapsed.Name = "txtElapsed"
        Me.txtElapsed.Size = New System.Drawing.Size(200, 20)
        Me.txtElapsed.TabIndex = 7
        '
        'lstIntervalSpan
        '
        Me.lstIntervalSpan.FormattingEnabled = True
        Me.lstIntervalSpan.Location = New System.Drawing.Point(100, 162)
        Me.lstIntervalSpan.Name = "lstIntervalSpan"
        Me.lstIntervalSpan.Size = New System.Drawing.Size(200, 108)
        Me.lstIntervalSpan.TabIndex = 6
        '
        'dtmEndSpan
        '
        Me.dtmEndSpan.Location = New System.Drawing.Point(100, 82)
        Me.dtmEndSpan.Name = "dtmEndSpan"
        Me.dtmEndSpan.Size = New System.Drawing.Size(200, 20)
        Me.dtmEndSpan.TabIndex = 5
        '
        'dtmStartSpan
        '
        Me.dtmStartSpan.Location = New System.Drawing.Point(100, 44)
        Me.dtmStartSpan.Name = "dtmStartSpan"
        Me.dtmStartSpan.Size = New System.Drawing.Size(200, 20)
        Me.dtmStartSpan.TabIndex = 4
        '
        'lblElapsedTime
        '
        Me.lblElapsedTime.AutoSize = True
        Me.lblElapsedTime.Location = New System.Drawing.Point(11, 292)
        Me.lblElapsedTime.Name = "lblElapsedTime"
        Me.lblElapsedTime.Size = New System.Drawing.Size(72, 13)
        Me.lblElapsedTime.TabIndex = 3
        Me.lblElapsedTime.Text = "Elapsed Units"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 162)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "What Interval?"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 88)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "End Time"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 50)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Start Time"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(664, 450)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(90, 31)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'errP
        '
        Me.errP.ContainerControl = Me
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(775, 509)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.grpSpan)
        Me.Controls.Add(Me.grpAdd)
        Me.Name = "frmMain"
        Me.Text = "Date and Time Handling Sample"
        Me.grpAdd.ResumeLayout(False)
        Me.grpAdd.PerformLayout()
        Me.grpSpan.ResumeLayout(False)
        Me.grpSpan.PerformLayout()
        CType(Me.errP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpAdd As GroupBox
    Friend WithEvents btnClearAdd As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents lblAlt As Label
    Friend WithEvents dtmEndAdd As DateTimePicker
    Friend WithEvents lblResult As Label
    Friend WithEvents txtQty As TextBox
    Friend WithEvents lstOp As ListBox
    Friend WithEvents lstIntervalAdd As ListBox
    Friend WithEvents dtmStartAdd As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents grpSpan As GroupBox
    Friend WithEvents btnExit As Button
    Friend WithEvents errP As ErrorProvider
    Friend WithEvents btnClearSpan As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnCalculateSpan As Button
    Friend WithEvents txtElapsed As TextBox
    Friend WithEvents lstIntervalSpan As ListBox
    Friend WithEvents dtmEndSpan As DateTimePicker
    Friend WithEvents dtmStartSpan As DateTimePicker
    Friend WithEvents lblElapsedTime As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
End Class
