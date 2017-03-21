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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.grpCust = New System.Windows.Forms.GroupBox()
        Me.tvwCust = New System.Windows.Forms.TreeView()
        Me.grpOrders = New System.Windows.Forms.GroupBox()
        Me.tvwOrders = New System.Windows.Forms.TreeView()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.grpWorkArea = New System.Windows.Forms.GroupBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SplitContainer4 = New System.Windows.Forms.SplitContainer()
        Me.ofdData = New System.Windows.Forms.OpenFileDialog()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.grpCust.SuspendLayout()
        Me.grpOrders.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer4.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer3)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(965, 553)
        Me.SplitContainer1.SplitterDistance = 193
        Me.SplitContainer1.TabIndex = 0
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.btnLoad)
        Me.SplitContainer3.Panel1.Controls.Add(Me.grpCust)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.grpOrders)
        Me.SplitContainer3.Size = New System.Drawing.Size(193, 553)
        Me.SplitContainer3.SplitterDistance = 280
        Me.SplitContainer3.TabIndex = 0
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(92, 247)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(86, 24)
        Me.btnLoad.TabIndex = 1
        Me.btnLoad.Text = "Load"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'grpCust
        '
        Me.grpCust.Controls.Add(Me.tvwCust)
        Me.grpCust.Location = New System.Drawing.Point(12, 12)
        Me.grpCust.Name = "grpCust"
        Me.grpCust.Size = New System.Drawing.Size(167, 228)
        Me.grpCust.TabIndex = 0
        Me.grpCust.TabStop = False
        Me.grpCust.Text = "CUSTOMER LIST"
        '
        'tvwCust
        '
        Me.tvwCust.Location = New System.Drawing.Point(12, 21)
        Me.tvwCust.Name = "tvwCust"
        Me.tvwCust.Size = New System.Drawing.Size(143, 197)
        Me.tvwCust.TabIndex = 0
        '
        'grpOrders
        '
        Me.grpOrders.Controls.Add(Me.tvwOrders)
        Me.grpOrders.Location = New System.Drawing.Point(12, 20)
        Me.grpOrders.Name = "grpOrders"
        Me.grpOrders.Size = New System.Drawing.Size(167, 228)
        Me.grpOrders.TabIndex = 1
        Me.grpOrders.TabStop = False
        Me.grpOrders.Text = "ORDERS"
        '
        'tvwOrders
        '
        Me.tvwOrders.Location = New System.Drawing.Point(11, 25)
        Me.tvwOrders.Name = "tvwOrders"
        Me.tvwOrders.Size = New System.Drawing.Size(143, 190)
        Me.tvwOrders.TabIndex = 0
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.grpWorkArea)
        Me.SplitContainer2.Panel1.Controls.Add(Me.btnExit)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.SplitContainer4)
        Me.SplitContainer2.Size = New System.Drawing.Size(768, 553)
        Me.SplitContainer2.SplitterDistance = 547
        Me.SplitContainer2.TabIndex = 0
        '
        'grpWorkArea
        '
        Me.grpWorkArea.Location = New System.Drawing.Point(20, 17)
        Me.grpWorkArea.Name = "grpWorkArea"
        Me.grpWorkArea.Size = New System.Drawing.Size(505, 478)
        Me.grpWorkArea.TabIndex = 1
        Me.grpWorkArea.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(428, 508)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(98, 33)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'SplitContainer4
        '
        Me.SplitContainer4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer4.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer4.Name = "SplitContainer4"
        Me.SplitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.SplitContainer4.Size = New System.Drawing.Size(217, 553)
        Me.SplitContainer4.SplitterDistance = 256
        Me.SplitContainer4.TabIndex = 0
        '
        'ofdData
        '
        Me.ofdData.FileName = "OpenFileDialog1"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(965, 553)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "frmMain"
        Me.Text = "MultiPane Sample"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        Me.grpCust.ResumeLayout(False)
        Me.grpOrders.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents SplitContainer3 As SplitContainer
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents SplitContainer4 As SplitContainer
    Friend WithEvents btnLoad As Button
    Friend WithEvents grpCust As GroupBox
    Friend WithEvents grpOrders As GroupBox
    Friend WithEvents tvwCust As TreeView
    Friend WithEvents tvwOrders As TreeView
    Friend WithEvents grpWorkArea As GroupBox
    Friend WithEvents btnExit As Button
    Friend WithEvents ofdData As OpenFileDialog
End Class
