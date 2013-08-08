<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SandwichBuilder
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
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.cbBread = New System.Windows.Forms.ComboBox()
        Me.cbCheese = New System.Windows.Forms.ComboBox()
        Me.cbMeat = New System.Windows.Forms.ComboBox()
        Me.tbName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbCondiments = New System.Windows.Forms.ListBox()
        Me.btnList = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(31, 221)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(75, 45)
        Me.btnCreate.TabIndex = 6
        Me.btnCreate.Text = "Create Sandwich"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(198, 243)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 8
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'cbBread
        '
        Me.cbBread.FormattingEnabled = True
        Me.cbBread.Items.AddRange(New Object() {"Rye", "Whole Wheat", "Pumpernickel", "Sourdough", "Sub roll"})
        Me.cbBread.Location = New System.Drawing.Point(108, 65)
        Me.cbBread.Name = "cbBread"
        Me.cbBread.Size = New System.Drawing.Size(121, 21)
        Me.cbBread.TabIndex = 2
        '
        'cbCheese
        '
        Me.cbCheese.FormattingEnabled = True
        Me.cbCheese.Items.AddRange(New Object() {"Pepper Jack", "Cheddar", "American", "Provolone"})
        Me.cbCheese.Location = New System.Drawing.Point(108, 92)
        Me.cbCheese.Name = "cbCheese"
        Me.cbCheese.Size = New System.Drawing.Size(121, 21)
        Me.cbCheese.TabIndex = 3
        '
        'cbMeat
        '
        Me.cbMeat.FormattingEnabled = True
        Me.cbMeat.Items.AddRange(New Object() {"Salami", "Bologna", "Roast Beef", "Turkey Breast", "Ham"})
        Me.cbMeat.Location = New System.Drawing.Point(108, 119)
        Me.cbMeat.Name = "cbMeat"
        Me.cbMeat.Size = New System.Drawing.Size(121, 21)
        Me.cbMeat.TabIndex = 4
        '
        'tbName
        '
        Me.tbName.Location = New System.Drawing.Point(108, 29)
        Me.tbName.Name = "tbName"
        Me.tbName.Size = New System.Drawing.Size(100, 20)
        Me.tbName.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Name this sandwich:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Bread"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Cheese"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Meat"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(31, 155)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Condiments"
        '
        'lbCondiments
        '
        Me.lbCondiments.FormattingEnabled = True
        Me.lbCondiments.Items.AddRange(New Object() {"Mayo", "Mustard", "Spicy Mustard", "Horseradish"})
        Me.lbCondiments.Location = New System.Drawing.Point(109, 155)
        Me.lbCondiments.Name = "lbCondiments"
        Me.lbCondiments.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lbCondiments.Size = New System.Drawing.Size(120, 56)
        Me.lbCondiments.TabIndex = 5
        '
        'btnList
        '
        Me.btnList.Location = New System.Drawing.Point(117, 221)
        Me.btnList.Name = "btnList"
        Me.btnList.Size = New System.Drawing.Size(75, 45)
        Me.btnList.TabIndex = 7
        Me.btnList.Text = "List Sandwiches"
        Me.btnList.UseVisualStyleBackColor = True
        '
        'SandwichBuilder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(296, 278)
        Me.Controls.Add(Me.btnList)
        Me.Controls.Add(Me.lbCondiments)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbName)
        Me.Controls.Add(Me.cbMeat)
        Me.Controls.Add(Me.cbCheese)
        Me.Controls.Add(Me.cbBread)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnCreate)
        Me.Name = "SandwichBuilder"
        Me.Text = "Build your sandwich"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCreate As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents cbBread As System.Windows.Forms.ComboBox
    Friend WithEvents cbCheese As System.Windows.Forms.ComboBox
    Friend WithEvents cbMeat As System.Windows.Forms.ComboBox
    Friend WithEvents tbName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lbCondiments As System.Windows.Forms.ListBox
    Friend WithEvents btnList As System.Windows.Forms.Button

End Class
