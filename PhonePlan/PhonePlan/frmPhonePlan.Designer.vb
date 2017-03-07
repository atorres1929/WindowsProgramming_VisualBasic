<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPhonePlan
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
        Me.radPhone1 = New System.Windows.Forms.RadioButton()
        Me.radPhone2 = New System.Windows.Forms.RadioButton()
        Me.radPhone3 = New System.Windows.Forms.RadioButton()
        Me.grpPhoneChoice = New System.Windows.Forms.GroupBox()
        Me.grpPlanChoice = New System.Windows.Forms.GroupBox()
        Me.radPlan200 = New System.Windows.Forms.RadioButton()
        Me.radPlanUnlimited = New System.Windows.Forms.RadioButton()
        Me.radPlan50 = New System.Windows.Forms.RadioButton()
        Me.radPlanBasic = New System.Windows.Forms.RadioButton()
        Me.picPhone = New System.Windows.Forms.PictureBox()
        Me.lblWarningScale = New System.Windows.Forms.Label()
        Me.chkOptionalDataPlan = New System.Windows.Forms.CheckBox()
        Me.lblOptionalDataPlan = New System.Windows.Forms.Label()
        Me.lblMonthlyFee = New System.Windows.Forms.Label()
        Me.lblPhonePlan = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.errP = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.grpPhoneChoice.SuspendLayout()
        Me.grpPlanChoice.SuspendLayout()
        CType(Me.picPhone, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'radPhone1
        '
        Me.radPhone1.AutoSize = True
        Me.radPhone1.Location = New System.Drawing.Point(17, 19)
        Me.radPhone1.Name = "radPhone1"
        Me.radPhone1.Size = New System.Drawing.Size(120, 17)
        Me.radPhone1.TabIndex = 0
        Me.radPhone1.TabStop = True
        Me.radPhone1.Text = "Samsung Galaxy S7"
        Me.radPhone1.UseVisualStyleBackColor = True
        '
        'radPhone2
        '
        Me.radPhone2.AutoSize = True
        Me.radPhone2.Location = New System.Drawing.Point(17, 58)
        Me.radPhone2.Name = "radPhone2"
        Me.radPhone2.Size = New System.Drawing.Size(84, 17)
        Me.radPhone2.TabIndex = 1
        Me.radPhone2.TabStop = True
        Me.radPhone2.Text = "Google Pixel"
        Me.radPhone2.UseVisualStyleBackColor = True
        '
        'radPhone3
        '
        Me.radPhone3.AutoSize = True
        Me.radPhone3.Location = New System.Drawing.Point(17, 98)
        Me.radPhone3.Name = "radPhone3"
        Me.radPhone3.Size = New System.Drawing.Size(67, 17)
        Me.radPhone3.TabIndex = 2
        Me.radPhone3.TabStop = True
        Me.radPhone3.Text = "iPhone 7"
        Me.radPhone3.UseVisualStyleBackColor = True
        '
        'grpPhoneChoice
        '
        Me.grpPhoneChoice.Controls.Add(Me.radPhone3)
        Me.grpPhoneChoice.Controls.Add(Me.radPhone2)
        Me.grpPhoneChoice.Controls.Add(Me.radPhone1)
        Me.grpPhoneChoice.Location = New System.Drawing.Point(24, 37)
        Me.grpPhoneChoice.Name = "grpPhoneChoice"
        Me.grpPhoneChoice.Size = New System.Drawing.Size(171, 137)
        Me.grpPhoneChoice.TabIndex = 3
        Me.grpPhoneChoice.TabStop = False
        Me.grpPhoneChoice.Text = "Phone Choices"
        '
        'grpPlanChoice
        '
        Me.grpPlanChoice.Controls.Add(Me.radPlan200)
        Me.grpPlanChoice.Controls.Add(Me.radPlanUnlimited)
        Me.grpPlanChoice.Controls.Add(Me.radPlan50)
        Me.grpPlanChoice.Controls.Add(Me.radPlanBasic)
        Me.grpPlanChoice.Location = New System.Drawing.Point(24, 235)
        Me.grpPlanChoice.Name = "grpPlanChoice"
        Me.grpPlanChoice.Size = New System.Drawing.Size(171, 120)
        Me.grpPlanChoice.TabIndex = 4
        Me.grpPlanChoice.TabStop = False
        Me.grpPlanChoice.Text = "Plan Choices"
        '
        'radPlan200
        '
        Me.radPlan200.AutoSize = True
        Me.radPlan200.Location = New System.Drawing.Point(17, 65)
        Me.radPlan200.Name = "radPlan200"
        Me.radPlan200.Size = New System.Drawing.Size(67, 17)
        Me.radPlan200.TabIndex = 3
        Me.radPlan200.TabStop = True
        Me.radPlan200.Text = "Text 200"
        Me.radPlan200.UseVisualStyleBackColor = True
        '
        'radPlanUnlimited
        '
        Me.radPlanUnlimited.AutoSize = True
        Me.radPlanUnlimited.Location = New System.Drawing.Point(17, 88)
        Me.radPlanUnlimited.Name = "radPlanUnlimited"
        Me.radPlanUnlimited.Size = New System.Drawing.Size(92, 17)
        Me.radPlanUnlimited.TabIndex = 2
        Me.radPlanUnlimited.TabStop = True
        Me.radPlanUnlimited.Text = "Text Unlimited"
        Me.radPlanUnlimited.UseVisualStyleBackColor = True
        '
        'radPlan50
        '
        Me.radPlan50.AutoSize = True
        Me.radPlan50.Location = New System.Drawing.Point(17, 42)
        Me.radPlan50.Name = "radPlan50"
        Me.radPlan50.Size = New System.Drawing.Size(61, 17)
        Me.radPlan50.TabIndex = 1
        Me.radPlan50.TabStop = True
        Me.radPlan50.Text = "Text 50"
        Me.radPlan50.UseVisualStyleBackColor = True
        '
        'radPlanBasic
        '
        Me.radPlanBasic.AutoSize = True
        Me.radPlanBasic.Location = New System.Drawing.Point(17, 19)
        Me.radPlanBasic.Name = "radPlanBasic"
        Me.radPlanBasic.Size = New System.Drawing.Size(51, 17)
        Me.radPlanBasic.TabIndex = 0
        Me.radPlanBasic.TabStop = True
        Me.radPlanBasic.Text = "Basic"
        Me.radPlanBasic.UseVisualStyleBackColor = True
        '
        'picPhone
        '
        Me.picPhone.Location = New System.Drawing.Point(237, 9)
        Me.picPhone.Name = "picPhone"
        Me.picPhone.Size = New System.Drawing.Size(419, 621)
        Me.picPhone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPhone.TabIndex = 5
        Me.picPhone.TabStop = False
        '
        'lblWarningScale
        '
        Me.lblWarningScale.AutoSize = True
        Me.lblWarningScale.Location = New System.Drawing.Point(370, 617)
        Me.lblWarningScale.Name = "lblWarningScale"
        Me.lblWarningScale.Size = New System.Drawing.Size(128, 13)
        Me.lblWarningScale.TabIndex = 6
        Me.lblWarningScale.Text = "Note: Images not to scale"
        '
        'chkOptionalDataPlan
        '
        Me.chkOptionalDataPlan.AutoSize = True
        Me.chkOptionalDataPlan.Location = New System.Drawing.Point(41, 376)
        Me.chkOptionalDataPlan.Name = "chkOptionalDataPlan"
        Me.chkOptionalDataPlan.Size = New System.Drawing.Size(115, 17)
        Me.chkOptionalDataPlan.TabIndex = 7
        Me.chkOptionalDataPlan.Tag = ""
        Me.chkOptionalDataPlan.Text = "Optional Data Plan"
        Me.chkOptionalDataPlan.UseVisualStyleBackColor = True
        '
        'lblOptionalDataPlan
        '
        Me.lblOptionalDataPlan.Location = New System.Drawing.Point(26, 396)
        Me.lblOptionalDataPlan.Name = "lblOptionalDataPlan"
        Me.lblOptionalDataPlan.Size = New System.Drawing.Size(169, 68)
        Me.lblOptionalDataPlan.TabIndex = 8
        Me.lblOptionalDataPlan.Text = "Optional Data Plan: Provides 2 GB of data transfer monthly for an additional char" &
    "ge of $20.00 per month"
        '
        'lblMonthlyFee
        '
        Me.lblMonthlyFee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMonthlyFee.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonthlyFee.Location = New System.Drawing.Point(12, 526)
        Me.lblMonthlyFee.Name = "lblMonthlyFee"
        Me.lblMonthlyFee.Size = New System.Drawing.Size(183, 44)
        Me.lblMonthlyFee.TabIndex = 9
        Me.lblMonthlyFee.Text = "Monthly Fee: $0.00"
        Me.lblMonthlyFee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPhonePlan
        '
        Me.lblPhonePlan.AutoSize = True
        Me.lblPhonePlan.Location = New System.Drawing.Point(27, 181)
        Me.lblPhonePlan.Name = "lblPhonePlan"
        Me.lblPhonePlan.Size = New System.Drawing.Size(0, 13)
        Me.lblPhonePlan.TabIndex = 10
        '
        'btnSubmit
        '
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(19, 596)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(89, 34)
        Me.btnSubmit.TabIndex = 11
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(106, 596)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(89, 34)
        Me.btnClear.TabIndex = 12
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'errP
        '
        Me.errP.ContainerControl = Me
        '
        'frmPhonePlan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(666, 710)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lblPhonePlan)
        Me.Controls.Add(Me.lblMonthlyFee)
        Me.Controls.Add(Me.lblOptionalDataPlan)
        Me.Controls.Add(Me.chkOptionalDataPlan)
        Me.Controls.Add(Me.lblWarningScale)
        Me.Controls.Add(Me.picPhone)
        Me.Controls.Add(Me.grpPlanChoice)
        Me.Controls.Add(Me.grpPhoneChoice)
        Me.Name = "frmPhonePlan"
        Me.Text = "Phone Plan"
        Me.grpPhoneChoice.ResumeLayout(False)
        Me.grpPhoneChoice.PerformLayout()
        Me.grpPlanChoice.ResumeLayout(False)
        Me.grpPlanChoice.PerformLayout()
        CType(Me.picPhone, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents radPhone1 As RadioButton
    Friend WithEvents radPhone2 As RadioButton
    Friend WithEvents radPhone3 As RadioButton
    Friend WithEvents grpPhoneChoice As GroupBox
    Friend WithEvents grpPlanChoice As GroupBox
    Friend WithEvents radPlanUnlimited As RadioButton
    Friend WithEvents radPlan50 As RadioButton
    Friend WithEvents radPlanBasic As RadioButton
    Friend WithEvents radPlan200 As RadioButton
    Friend WithEvents picPhone As PictureBox
    Friend WithEvents lblWarningScale As Label
    Friend WithEvents chkOptionalDataPlan As CheckBox
    Friend WithEvents lblOptionalDataPlan As Label
    Friend WithEvents lblMonthlyFee As Label
    Friend WithEvents lblPhonePlan As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents errP As ErrorProvider
End Class
