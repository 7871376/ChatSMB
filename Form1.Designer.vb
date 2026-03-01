<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChatSMB
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChatSMB))
        Me.Panel0 = New System.Windows.Forms.Panel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.LabelReceived = New System.Windows.Forms.Label()
        Me.PanelSend = New System.Windows.Forms.Panel()
        Me.PanelTextbox = New System.Windows.Forms.Panel()
        Me.TxtSend = New System.Windows.Forms.TextBox()
        Me.ButtonSend = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel0.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.PanelSend.SuspendLayout()
        Me.PanelTextbox.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel0
        '
        Me.Panel0.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Panel0.Controls.Add(Me.SplitContainer1)
        Me.Panel0.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel0.Location = New System.Drawing.Point(15, 10)
        Me.Panel0.Name = "Panel0"
        Me.Panel0.Size = New System.Drawing.Size(1170, 522)
        Me.Panel0.TabIndex = 0
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.LabelReceived)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.PanelSend)
        Me.SplitContainer1.Size = New System.Drawing.Size(1170, 522)
        Me.SplitContainer1.SplitterDistance = 384
        Me.SplitContainer1.TabIndex = 0
        '
        'LabelReceived
        '
        Me.LabelReceived.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelReceived.Font = New System.Drawing.Font("Diary of an 8-bit mage", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelReceived.Location = New System.Drawing.Point(0, 0)
        Me.LabelReceived.Margin = New System.Windows.Forms.Padding(10)
        Me.LabelReceived.Name = "LabelReceived"
        Me.LabelReceived.Padding = New System.Windows.Forms.Padding(10)
        Me.LabelReceived.Size = New System.Drawing.Size(1170, 384)
        Me.LabelReceived.TabIndex = 0
        '
        'PanelSend
        '
        Me.PanelSend.Controls.Add(Me.PanelTextbox)
        Me.PanelSend.Controls.Add(Me.ButtonSend)
        Me.PanelSend.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelSend.Location = New System.Drawing.Point(0, 0)
        Me.PanelSend.Margin = New System.Windows.Forms.Padding(10)
        Me.PanelSend.Name = "PanelSend"
        Me.PanelSend.Padding = New System.Windows.Forms.Padding(10)
        Me.PanelSend.Size = New System.Drawing.Size(1170, 134)
        Me.PanelSend.TabIndex = 2
        '
        'PanelTextbox
        '
        Me.PanelTextbox.BackColor = System.Drawing.Color.White
        Me.PanelTextbox.Controls.Add(Me.TxtSend)
        Me.PanelTextbox.Location = New System.Drawing.Point(13, 13)
        Me.PanelTextbox.Name = "PanelTextbox"
        Me.PanelTextbox.Padding = New System.Windows.Forms.Padding(10)
        Me.PanelTextbox.Size = New System.Drawing.Size(980, 80)
        Me.PanelTextbox.TabIndex = 2
        '
        'TxtSend
        '
        Me.TxtSend.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtSend.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtSend.Font = New System.Drawing.Font("Diary of an 8-bit mage", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSend.Location = New System.Drawing.Point(10, 10)
        Me.TxtSend.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtSend.Multiline = True
        Me.TxtSend.Name = "TxtSend"
        Me.TxtSend.Size = New System.Drawing.Size(960, 60)
        Me.TxtSend.TabIndex = 0
        '
        'ButtonSend
        '
        Me.ButtonSend.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonSend.AutoSize = True
        Me.ButtonSend.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ButtonSend.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ButtonSend.Location = New System.Drawing.Point(1010, 30)
        Me.ButtonSend.Margin = New System.Windows.Forms.Padding(10)
        Me.ButtonSend.Name = "ButtonSend"
        Me.ButtonSend.Size = New System.Drawing.Size(140, 53)
        Me.ButtonSend.TabIndex = 1
        Me.ButtonSend.Text = "Send"
        Me.ButtonSend.UseVisualStyleBackColor = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.PaleTurquoise
        Me.StatusStrip1.Font = New System.Drawing.Font("Diary of an 8-bit mage", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(15, 510)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1170, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 17)
        '
        'ChatSMB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HighlightText
        Me.ClientSize = New System.Drawing.Size(1200, 542)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel0)
        Me.Font = New System.Drawing.Font("Diary of an 8-bit mage", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "ChatSMB"
        Me.Padding = New System.Windows.Forms.Padding(15, 10, 15, 10)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ChatSMB"
        Me.Panel0.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.PanelSend.ResumeLayout(False)
        Me.PanelSend.PerformLayout()
        Me.PanelTextbox.ResumeLayout(False)
        Me.PanelTextbox.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel0 As Panel
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents LabelReceived As Label
    Friend WithEvents ButtonSend As Button
    Friend WithEvents TxtSend As TextBox
    Friend WithEvents PanelSend As Panel
    Friend WithEvents PanelTextbox As Panel
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
End Class
