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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.wbMovieList = New System.Windows.Forms.WebBrowser()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnClose = New System.Windows.Forms.ToolStripButton()
        Me.btnChooseCity = New System.Windows.Forms.ToolStripSplitButton()
        Me.AustinToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HoustonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'wbMovieList
        '
        Me.wbMovieList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.wbMovieList.Location = New System.Drawing.Point(0, 0)
        Me.wbMovieList.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbMovieList.Name = "wbMovieList"
        Me.wbMovieList.ScriptErrorsSuppressed = True
        Me.wbMovieList.Size = New System.Drawing.Size(1184, 750)
        Me.wbMovieList.TabIndex = 0
        Me.wbMovieList.Visible = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnChooseCity, Me.btnClose})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1184, 25)
        Me.ToolStrip1.Stretch = True
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnClose
        '
        Me.btnClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(40, 22)
        Me.btnClose.Text = "Close"
        '
        'btnChooseCity
        '
        Me.btnChooseCity.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnChooseCity.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AustinToolStripMenuItem, Me.HoustonToolStripMenuItem})
        Me.btnChooseCity.Image = CType(resources.GetObject("btnChooseCity.Image"), System.Drawing.Image)
        Me.btnChooseCity.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnChooseCity.Name = "btnChooseCity"
        Me.btnChooseCity.Size = New System.Drawing.Size(115, 22)
        Me.btnChooseCity.Text = "Choose Your City"
        '
        'AustinToolStripMenuItem
        '
        Me.AustinToolStripMenuItem.Name = "AustinToolStripMenuItem"
        Me.AustinToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AustinToolStripMenuItem.Text = "Austin"
        '
        'HoustonToolStripMenuItem
        '
        Me.HoustonToolStripMenuItem.Name = "HoustonToolStripMenuItem"
        Me.HoustonToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.HoustonToolStripMenuItem.Text = "Houston"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1184, 750)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.wbMovieList)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "Movie Listings by City"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents wbMovieList As System.Windows.Forms.WebBrowser
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnChooseCity As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents AustinToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HoustonToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
