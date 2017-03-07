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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.tvwFaves = New System.Windows.Forms.TreeView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.webDoc = New System.Windows.Forms.WebBrowser()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbGoURL = New System.Windows.Forms.ToolStripButton()
        Me.tsbGoPrev = New System.Windows.Forms.ToolStripButton()
        Me.tsbNext = New System.Windows.Forms.ToolStripButton()
        Me.tsbAddFave = New System.Windows.Forms.ToolStripButton()
        Me.tsbBuild = New System.Windows.Forms.ToolStripButton()
        Me.tsbGetText = New System.Windows.Forms.ToolStripButton()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnExit)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnRemove)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnGo)
        Me.SplitContainer1.Panel1.Controls.Add(Me.tvwFaves)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.webDoc)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ToolStrip1)
        Me.SplitContainer1.Size = New System.Drawing.Size(717, 502)
        Me.SplitContainer1.SplitterDistance = 219
        Me.SplitContainer1.TabIndex = 0
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(29, 412)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(153, 24)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(113, 382)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(69, 24)
        Me.btnRemove.TabIndex = 3
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(29, 382)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(69, 24)
        Me.btnGo.TabIndex = 2
        Me.btnGo.Text = "Go"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'tvwFaves
        '
        Me.tvwFaves.Location = New System.Drawing.Point(14, 43)
        Me.tvwFaves.Name = "tvwFaves"
        Me.tvwFaves.Size = New System.Drawing.Size(188, 317)
        Me.tvwFaves.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Favorites"
        '
        'webDoc
        '
        Me.webDoc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.webDoc.Location = New System.Drawing.Point(0, 25)
        Me.webDoc.MinimumSize = New System.Drawing.Size(20, 20)
        Me.webDoc.Name = "webDoc"
        Me.webDoc.Size = New System.Drawing.Size(494, 477)
        Me.webDoc.TabIndex = 1
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGoURL, Me.tsbGoPrev, Me.tsbNext, Me.tsbAddFave, Me.tsbBuild, Me.tsbGetText})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(494, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbGoURL
        '
        Me.tsbGoURL.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbGoURL.Image = CType(resources.GetObject("tsbGoURL.Image"), System.Drawing.Image)
        Me.tsbGoURL.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGoURL.Name = "tsbGoURL"
        Me.tsbGoURL.Size = New System.Drawing.Size(50, 22)
        Me.tsbGoURL.Text = "Go URL"
        '
        'tsbGoPrev
        '
        Me.tsbGoPrev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbGoPrev.Image = CType(resources.GetObject("tsbGoPrev.Image"), System.Drawing.Image)
        Me.tsbGoPrev.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGoPrev.Name = "tsbGoPrev"
        Me.tsbGoPrev.Size = New System.Drawing.Size(56, 22)
        Me.tsbGoPrev.Text = "Previous"
        '
        'tsbNext
        '
        Me.tsbNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbNext.Image = CType(resources.GetObject("tsbNext.Image"), System.Drawing.Image)
        Me.tsbNext.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbNext.Name = "tsbNext"
        Me.tsbNext.Size = New System.Drawing.Size(35, 22)
        Me.tsbNext.Text = "Next"
        '
        'tsbAddFave
        '
        Me.tsbAddFave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbAddFave.Image = CType(resources.GetObject("tsbAddFave.Image"), System.Drawing.Image)
        Me.tsbAddFave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAddFave.Name = "tsbAddFave"
        Me.tsbAddFave.Size = New System.Drawing.Size(79, 22)
        Me.tsbAddFave.Text = "Add to Faves"
        '
        'tsbBuild
        '
        Me.tsbBuild.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbBuild.Image = CType(resources.GetObject("tsbBuild.Image"), System.Drawing.Image)
        Me.tsbBuild.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbBuild.Name = "tsbBuild"
        Me.tsbBuild.Size = New System.Drawing.Size(67, 22)
        Me.tsbBuild.Text = "Build Page"
        '
        'tsbGetText
        '
        Me.tsbGetText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbGetText.Image = CType(resources.GetObject("tsbGetText.Image"), System.Drawing.Image)
        Me.tsbGetText.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGetText.Name = "tsbGetText"
        Me.tsbGetText.Size = New System.Drawing.Size(53, 22)
        Me.tsbGetText.Text = "Get Text"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(717, 502)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "frmMain"
        Me.Text = "WebBrowser Sample"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents btnExit As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnGo As Button
    Friend WithEvents tvwFaves As TreeView
    Friend WithEvents Label1 As Label
    Friend WithEvents webDoc As WebBrowser
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tsbGoURL As ToolStripButton
    Friend WithEvents tsbGoPrev As ToolStripButton
    Friend WithEvents tsbNext As ToolStripButton
    Friend WithEvents tsbAddFave As ToolStripButton
    Friend WithEvents tsbBuild As ToolStripButton
    Friend WithEvents tsbGetText As ToolStripButton
End Class
