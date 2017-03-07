<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChoice
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboChoices = New System.Windows.Forms.ComboBox()
        Me.lstSizes = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.clbHats = New System.Windows.Forms.CheckedListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtmApproval = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.mclSaleRange = New System.Windows.Forms.MonthCalendar()
        Me.radRed = New System.Windows.Forms.RadioButton()
        Me.radBlue = New System.Windows.Forms.RadioButton()
        Me.radGreen = New System.Windows.Forms.RadioButton()
        Me.radBlack = New System.Windows.Forms.RadioButton()
        Me.radSilver = New System.Windows.Forms.RadioButton()
        Me.radGold = New System.Windows.Forms.RadioButton()
        Me.grpColors = New System.Windows.Forms.GroupBox()
        Me.grpTrim = New System.Windows.Forms.GroupBox()
        Me.chkExpress = New System.Windows.Forms.CheckBox()
        Me.chkSaturday = New System.Windows.Forms.CheckBox()
        Me.chkResidence = New System.Windows.Forms.CheckBox()
        Me.grpDelivery = New System.Windows.Forms.GroupBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.errP = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grpColors.SuspendLayout()
        Me.grpTrim.SuspendLayout()
        Me.grpDelivery.SuspendLayout()
        CType(Me.errP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(56, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(178, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ComboBox - Safe Items"
        '
        'cboChoices
        '
        Me.cboChoices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboChoices.FormattingEnabled = True
        Me.cboChoices.Location = New System.Drawing.Point(60, 68)
        Me.cboChoices.Name = "cboChoices"
        Me.cboChoices.Size = New System.Drawing.Size(174, 21)
        Me.cboChoices.TabIndex = 1
        '
        'lstSizes
        '
        Me.lstSizes.FormattingEnabled = True
        Me.lstSizes.Location = New System.Drawing.Point(60, 119)
        Me.lstSizes.Name = "lstSizes"
        Me.lstSizes.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lstSizes.Size = New System.Drawing.Size(174, 95)
        Me.lstSizes.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(60, 217)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(153, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "CheckListBox - Hats"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(60, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "ListBox - Sizes"
        '
        'clbHats
        '
        Me.clbHats.CheckOnClick = True
        Me.clbHats.FormattingEnabled = True
        Me.clbHats.Location = New System.Drawing.Point(60, 241)
        Me.clbHats.Name = "clbHats"
        Me.clbHats.Size = New System.Drawing.Size(174, 94)
        Me.clbHats.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(286, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(235, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "DateTimePicker - Approval Date"
        '
        'dtmApproval
        '
        Me.dtmApproval.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtmApproval.Location = New System.Drawing.Point(290, 68)
        Me.dtmApproval.Name = "dtmApproval"
        Me.dtmApproval.Size = New System.Drawing.Size(157, 20)
        Me.dtmApproval.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(286, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(254, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "MonthCalendar - Sale Date Range"
        '
        'mclSaleRange
        '
        Me.mclSaleRange.Location = New System.Drawing.Point(286, 126)
        Me.mclSaleRange.Name = "mclSaleRange"
        Me.mclSaleRange.TabIndex = 10
        '
        'radRed
        '
        Me.radRed.AutoSize = True
        Me.radRed.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.radRed.Location = New System.Drawing.Point(26, 31)
        Me.radRed.Name = "radRed"
        Me.radRed.Size = New System.Drawing.Size(57, 24)
        Me.radRed.TabIndex = 12
        Me.radRed.TabStop = True
        Me.radRed.Text = "Red"
        Me.radRed.UseVisualStyleBackColor = True
        '
        'radBlue
        '
        Me.radBlue.AutoSize = True
        Me.radBlue.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.radBlue.Location = New System.Drawing.Point(26, 57)
        Me.radBlue.Name = "radBlue"
        Me.radBlue.Size = New System.Drawing.Size(59, 24)
        Me.radBlue.TabIndex = 13
        Me.radBlue.TabStop = True
        Me.radBlue.Text = "Blue"
        Me.radBlue.UseVisualStyleBackColor = True
        '
        'radGreen
        '
        Me.radGreen.AutoSize = True
        Me.radGreen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.radGreen.Location = New System.Drawing.Point(26, 83)
        Me.radGreen.Name = "radGreen"
        Me.radGreen.Size = New System.Drawing.Size(72, 24)
        Me.radGreen.TabIndex = 14
        Me.radGreen.TabStop = True
        Me.radGreen.Text = "Green"
        Me.radGreen.UseVisualStyleBackColor = True
        '
        'radBlack
        '
        Me.radBlack.AutoSize = True
        Me.radBlack.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.radBlack.Location = New System.Drawing.Point(17, 77)
        Me.radBlack.Name = "radBlack"
        Me.radBlack.Size = New System.Drawing.Size(66, 24)
        Me.radBlack.TabIndex = 18
        Me.radBlack.TabStop = True
        Me.radBlack.Text = "Black"
        Me.radBlack.UseVisualStyleBackColor = True
        '
        'radSilver
        '
        Me.radSilver.AutoSize = True
        Me.radSilver.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.radSilver.Location = New System.Drawing.Point(17, 51)
        Me.radSilver.Name = "radSilver"
        Me.radSilver.Size = New System.Drawing.Size(65, 24)
        Me.radSilver.TabIndex = 17
        Me.radSilver.TabStop = True
        Me.radSilver.Text = "Silver"
        Me.radSilver.UseVisualStyleBackColor = True
        '
        'radGold
        '
        Me.radGold.AutoSize = True
        Me.radGold.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.radGold.Location = New System.Drawing.Point(17, 25)
        Me.radGold.Name = "radGold"
        Me.radGold.Size = New System.Drawing.Size(61, 24)
        Me.radGold.TabIndex = 16
        Me.radGold.TabStop = True
        Me.radGold.Text = "Gold"
        Me.radGold.UseVisualStyleBackColor = True
        '
        'grpColors
        '
        Me.grpColors.Controls.Add(Me.radGreen)
        Me.grpColors.Controls.Add(Me.radBlue)
        Me.grpColors.Controls.Add(Me.radRed)
        Me.grpColors.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.grpColors.Location = New System.Drawing.Point(575, 44)
        Me.grpColors.Name = "grpColors"
        Me.grpColors.Size = New System.Drawing.Size(178, 113)
        Me.grpColors.TabIndex = 19
        Me.grpColors.TabStop = False
        Me.grpColors.Text = "RadioButtons - Color"
        '
        'grpTrim
        '
        Me.grpTrim.Controls.Add(Me.radBlack)
        Me.grpTrim.Controls.Add(Me.radSilver)
        Me.grpTrim.Controls.Add(Me.radGold)
        Me.grpTrim.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.grpTrim.Location = New System.Drawing.Point(575, 170)
        Me.grpTrim.Name = "grpTrim"
        Me.grpTrim.Size = New System.Drawing.Size(206, 118)
        Me.grpTrim.TabIndex = 20
        Me.grpTrim.TabStop = False
        Me.grpTrim.Text = "More RadioButtons - Trim"
        '
        'chkExpress
        '
        Me.chkExpress.AutoSize = True
        Me.chkExpress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.chkExpress.Location = New System.Drawing.Point(15, 20)
        Me.chkExpress.Name = "chkExpress"
        Me.chkExpress.Size = New System.Drawing.Size(151, 24)
        Me.chkExpress.TabIndex = 21
        Me.chkExpress.Text = "Express Shipping"
        Me.chkExpress.UseVisualStyleBackColor = True
        '
        'chkSaturday
        '
        Me.chkSaturday.AutoSize = True
        Me.chkSaturday.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.chkSaturday.Location = New System.Drawing.Point(15, 50)
        Me.chkSaturday.Name = "chkSaturday"
        Me.chkSaturday.Size = New System.Drawing.Size(151, 24)
        Me.chkSaturday.TabIndex = 22
        Me.chkSaturday.Text = "Saturday Delivery"
        Me.chkSaturday.UseVisualStyleBackColor = True
        '
        'chkResidence
        '
        Me.chkResidence.AutoSize = True
        Me.chkResidence.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.chkResidence.Location = New System.Drawing.Point(15, 80)
        Me.chkResidence.Name = "chkResidence"
        Me.chkResidence.Size = New System.Drawing.Size(170, 24)
        Me.chkResidence.TabIndex = 23
        Me.chkResidence.Text = "Residential Address"
        Me.chkResidence.UseVisualStyleBackColor = True
        '
        'grpDelivery
        '
        Me.grpDelivery.Controls.Add(Me.chkResidence)
        Me.grpDelivery.Controls.Add(Me.chkSaturday)
        Me.grpDelivery.Controls.Add(Me.chkExpress)
        Me.grpDelivery.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.grpDelivery.Location = New System.Drawing.Point(577, 294)
        Me.grpDelivery.Name = "grpDelivery"
        Me.grpDelivery.Size = New System.Drawing.Size(204, 118)
        Me.grpDelivery.TabIndex = 24
        Me.grpDelivery.TabStop = False
        Me.grpDelivery.Text = "CheckBoxes - Delivery"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(845, 93)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 25
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnReport
        '
        Me.btnReport.Location = New System.Drawing.Point(845, 44)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(75, 23)
        Me.btnReport.TabIndex = 26
        Me.btnReport.Text = "Report Values"
        Me.btnReport.UseVisualStyleBackColor = True
        '
        'errP
        '
        Me.errP.ContainerControl = Me
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(845, 151)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 27
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmChoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1130, 534)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReport)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.grpDelivery)
        Me.Controls.Add(Me.grpTrim)
        Me.Controls.Add(Me.grpColors)
        Me.Controls.Add(Me.mclSaleRange)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dtmApproval)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.clbHats)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lstSizes)
        Me.Controls.Add(Me.cboChoices)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmChoice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Controls that Provide Choices"
        Me.grpColors.ResumeLayout(False)
        Me.grpColors.PerformLayout()
        Me.grpTrim.ResumeLayout(False)
        Me.grpTrim.PerformLayout()
        Me.grpDelivery.ResumeLayout(False)
        Me.grpDelivery.PerformLayout()
        CType(Me.errP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cboChoices As ComboBox
    Friend WithEvents lstSizes As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents clbHats As CheckedListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dtmApproval As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents mclSaleRange As MonthCalendar
    Friend WithEvents radRed As RadioButton
    Friend WithEvents radBlue As RadioButton
    Friend WithEvents radGreen As RadioButton
    Friend WithEvents radBlack As RadioButton
    Friend WithEvents radSilver As RadioButton
    Friend WithEvents radGold As RadioButton
    Friend WithEvents grpColors As GroupBox
    Friend WithEvents grpTrim As GroupBox
    Friend WithEvents chkExpress As CheckBox
    Friend WithEvents chkSaturday As CheckBox
    Friend WithEvents chkResidence As CheckBox
    Friend WithEvents grpDelivery As GroupBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnReport As Button
    Friend WithEvents errP As ErrorProvider
    Friend WithEvents btnExit As Button
End Class
