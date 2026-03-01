<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormKeyPath
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormKeyPath))
        Me.Panel0 = New System.Windows.Forms.Panel()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TxtPath = New System.Windows.Forms.TextBox()
        Me.LabelPath = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel0.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel0
        '
        Me.Panel0.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Panel0.Controls.Add(Me.Button1)
        Me.Panel0.Controls.Add(Me.LabelPath)
        Me.Panel0.Controls.Add(Me.TxtPath)
        Me.Panel0.Location = New System.Drawing.Point(8, 8)
        Me.Panel0.Margin = New System.Windows.Forms.Padding(10)
        Me.Panel0.Name = "Panel0"
        Me.Panel0.Padding = New System.Windows.Forms.Padding(10)
        Me.Panel0.Size = New System.Drawing.Size(1048, 96)
        Me.Panel0.TabIndex = 0
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'TxtPath
        '
        Me.TxtPath.Font = New System.Drawing.Font("Diary of an 8-bit mage", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPath.Location = New System.Drawing.Point(10, 35)
        Me.TxtPath.Name = "TxtPath"
        Me.TxtPath.Size = New System.Drawing.Size(859, 23)
        Me.TxtPath.TabIndex = 0
        '
        'LabelPath
        '
        Me.LabelPath.AutoSize = True
        Me.LabelPath.Font = New System.Drawing.Font("Diary of an 8-bit mage", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPath.Location = New System.Drawing.Point(17, 13)
        Me.LabelPath.Name = "LabelPath"
        Me.LabelPath.Size = New System.Drawing.Size(125, 16)
        Me.LabelPath.TabIndex = 1
        Me.LabelPath.Text = "Key File Path"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Diary of an 8-bit mage", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(885, 22)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 48)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Search"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FormKeyPath
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 113)
        Me.Controls.Add(Me.Panel0)
        Me.Font = New System.Drawing.Font("Diary of an 8-bit mage", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "FormKeyPath"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ChatSMB"
        Me.TopMost = True
        Me.Panel0.ResumeLayout(False)
        Me.Panel0.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel0 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents LabelPath As Label
    Friend WithEvents TxtPath As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
