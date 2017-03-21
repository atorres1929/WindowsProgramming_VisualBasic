<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class subfrmOrder
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.grpCustDetail = New System.Windows.Forms.GroupBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtCustomerID = New System.Windows.Forms.TextBox()
        Me.txtOrderID = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpCustDetail.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpCustDetail
        '
        Me.grpCustDetail.Controls.Add(Me.btnClear)
        Me.grpCustDetail.Controls.Add(Me.btnSave)
        Me.grpCustDetail.Controls.Add(Me.TextBox4)
        Me.grpCustDetail.Controls.Add(Me.TextBox3)
        Me.grpCustDetail.Controls.Add(Me.txtName)
        Me.grpCustDetail.Controls.Add(Me.txtCustomerID)
        Me.grpCustDetail.Controls.Add(Me.txtOrderID)
        Me.grpCustDetail.Controls.Add(Me.Label6)
        Me.grpCustDetail.Controls.Add(Me.Label5)
        Me.grpCustDetail.Controls.Add(Me.Label4)
        Me.grpCustDetail.Controls.Add(Me.Label3)
        Me.grpCustDetail.Controls.Add(Me.Label2)
        Me.grpCustDetail.Controls.Add(Me.Label1)
        Me.grpCustDetail.Location = New System.Drawing.Point(32, 27)
        Me.grpCustDetail.Name = "grpCustDetail"
        Me.grpCustDetail.Size = New System.Drawing.Size(368, 331)
        Me.grpCustDetail.TabIndex = 1
        Me.grpCustDetail.TabStop = False
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(242, 272)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(84, 29)
        Me.btnClear.TabIndex = 18
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(142, 272)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(84, 29)
        Me.btnSave.TabIndex = 17
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(142, 223)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(184, 20)
        Me.TextBox4.TabIndex = 14
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(142, 186)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(184, 20)
        Me.TextBox3.TabIndex = 13
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(142, 148)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(184, 20)
        Me.txtName.TabIndex = 12
        '
        'txtCustomerID
        '
        Me.txtCustomerID.Location = New System.Drawing.Point(142, 113)
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.Size = New System.Drawing.Size(184, 20)
        Me.txtCustomerID.TabIndex = 11
        '
        'txtOrderID
        '
        Me.txtOrderID.Location = New System.Drawing.Point(142, 78)
        Me.txtOrderID.Name = "txtOrderID"
        Me.txtOrderID.Size = New System.Drawing.Size(184, 20)
        Me.txtOrderID.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 226)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Total Order Value"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 189)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Customer ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Order ID"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(323, 34)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Order Information"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'subfrmOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.Controls.Add(Me.grpCustDetail)
        Me.Name = "subfrmOrder"
        Me.Size = New System.Drawing.Size(433, 415)
        Me.grpCustDetail.ResumeLayout(False)
        Me.grpCustDetail.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpCustDetail As GroupBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtCustomerID As TextBox
    Friend WithEvents txtOrderID As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
