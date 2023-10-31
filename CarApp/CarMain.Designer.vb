<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CarMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CarMain))
        Me.CarBrand = New System.Windows.Forms.ComboBox()
        Me.Car = New System.Windows.Forms.ComboBox()
        Me.Price = New System.Windows.Forms.TextBox()
        Me.YearsToPay = New System.Windows.Forms.TextBox()
        Me.Interest = New System.Windows.Forms.TextBox()
        Me.TotalPrice = New System.Windows.Forms.TextBox()
        Me.MonthlyDue = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Buy = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Reset = New System.Windows.Forms.Button()
        Me.CarBrand1 = New System.Windows.Forms.PictureBox()
        Me.CarBrand0 = New System.Windows.Forms.PictureBox()
        Me.CarPic = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.CarBrand1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CarBrand0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CarPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CarBrand
        '
        Me.CarBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CarBrand.Font = New System.Drawing.Font("HP Simplified", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CarBrand.FormattingEnabled = True
        Me.CarBrand.Items.AddRange(New Object() {"Honda", "Kia", "Nissan", "Toyota"})
        Me.CarBrand.Location = New System.Drawing.Point(11, 73)
        Me.CarBrand.Name = "CarBrand"
        Me.CarBrand.Size = New System.Drawing.Size(300, 27)
        Me.CarBrand.TabIndex = 0
        '
        'Car
        '
        Me.Car.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Car.Font = New System.Drawing.Font("HP Simplified", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Car.FormattingEnabled = True
        Me.Car.Location = New System.Drawing.Point(317, 73)
        Me.Car.Name = "Car"
        Me.Car.Size = New System.Drawing.Size(259, 27)
        Me.Car.TabIndex = 1
        '
        'Price
        '
        Me.Price.Font = New System.Drawing.Font("HP Simplified", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Price.Location = New System.Drawing.Point(148, 114)
        Me.Price.Name = "Price"
        Me.Price.ReadOnly = True
        Me.Price.Size = New System.Drawing.Size(163, 26)
        Me.Price.TabIndex = 3
        '
        'YearsToPay
        '
        Me.YearsToPay.Font = New System.Drawing.Font("HP Simplified", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.YearsToPay.Location = New System.Drawing.Point(148, 147)
        Me.YearsToPay.MaxLength = 3
        Me.YearsToPay.Name = "YearsToPay"
        Me.YearsToPay.Size = New System.Drawing.Size(163, 26)
        Me.YearsToPay.TabIndex = 4
        '
        'Interest
        '
        Me.Interest.Font = New System.Drawing.Font("HP Simplified", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Interest.Location = New System.Drawing.Point(148, 179)
        Me.Interest.Name = "Interest"
        Me.Interest.ReadOnly = True
        Me.Interest.Size = New System.Drawing.Size(163, 26)
        Me.Interest.TabIndex = 5
        '
        'TotalPrice
        '
        Me.TotalPrice.Font = New System.Drawing.Font("HP Simplified", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalPrice.Location = New System.Drawing.Point(148, 211)
        Me.TotalPrice.Name = "TotalPrice"
        Me.TotalPrice.ReadOnly = True
        Me.TotalPrice.Size = New System.Drawing.Size(163, 26)
        Me.TotalPrice.TabIndex = 6
        '
        'MonthlyDue
        '
        Me.MonthlyDue.Font = New System.Drawing.Font("HP Simplified", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthlyDue.Location = New System.Drawing.Point(148, 243)
        Me.MonthlyDue.Name = "MonthlyDue"
        Me.MonthlyDue.ReadOnly = True
        Me.MonthlyDue.Size = New System.Drawing.Size(163, 26)
        Me.MonthlyDue.TabIndex = 6
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Margin = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(6)
        Me.MenuStrip1.Size = New System.Drawing.Size(588, 32)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.HomeToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.HomeToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.HomeToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.HomeToolStripMenuItem.Image = CType(resources.GetObject("HomeToolStripMenuItem.Image"), System.Drawing.Image)
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(28, 20)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(7, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 21)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Car Dealership"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("HP Simplified", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(6, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 28)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Car Brand:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("HP Simplified", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(312, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 28)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Car:"
        '
        'Buy
        '
        Me.Buy.BackColor = System.Drawing.Color.LightGreen
        Me.Buy.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Buy.FlatAppearance.BorderSize = 2
        Me.Buy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen
        Me.Buy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.Buy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Buy.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buy.Location = New System.Drawing.Point(148, 275)
        Me.Buy.Name = "Buy"
        Me.Buy.Size = New System.Drawing.Size(163, 30)
        Me.Buy.TabIndex = 2
        Me.Buy.Text = "Buy"
        Me.Buy.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("HP Simplified", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(59, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 23)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Car Price:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("HP Simplified", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(19, 147)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 23)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Year(s) To Pay:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("HP Simplified", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(7, 179)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(135, 23)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Annual Interest:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("HP Simplified", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(46, 211)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 23)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Total Price:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("HP Simplified", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(20, 243)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(122, 23)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Monthly Dues:"
        '
        'Reset
        '
        Me.Reset.BackColor = System.Drawing.Color.Salmon
        Me.Reset.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Reset.FlatAppearance.BorderSize = 2
        Me.Reset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Salmon
        Me.Reset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato
        Me.Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Reset.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Reset.Location = New System.Drawing.Point(20, 275)
        Me.Reset.Name = "Reset"
        Me.Reset.Size = New System.Drawing.Size(122, 30)
        Me.Reset.TabIndex = 16
        Me.Reset.Text = "Reset"
        Me.Reset.UseVisualStyleBackColor = False
        '
        'CarBrand1
        '
        Me.CarBrand1.Location = New System.Drawing.Point(368, 42)
        Me.CarBrand1.Name = "CarBrand1"
        Me.CarBrand1.Size = New System.Drawing.Size(32, 28)
        Me.CarBrand1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CarBrand1.TabIndex = 19
        Me.CarBrand1.TabStop = False
        '
        'CarBrand0
        '
        Me.CarBrand0.Location = New System.Drawing.Point(126, 42)
        Me.CarBrand0.Name = "CarBrand0"
        Me.CarBrand0.Size = New System.Drawing.Size(32, 28)
        Me.CarBrand0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CarBrand0.TabIndex = 18
        Me.CarBrand0.TabStop = False
        '
        'CarPic
        '
        Me.CarPic.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.CarPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CarPic.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.CarPic.Location = New System.Drawing.Point(317, 114)
        Me.CarPic.Name = "CarPic"
        Me.CarPic.Size = New System.Drawing.Size(259, 191)
        Me.CarPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.CarPic.TabIndex = 17
        Me.CarPic.TabStop = False
        '
        'CarMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(588, 319)
        Me.Controls.Add(Me.CarBrand1)
        Me.Controls.Add(Me.CarBrand0)
        Me.Controls.Add(Me.CarPic)
        Me.Controls.Add(Me.Reset)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.MonthlyDue)
        Me.Controls.Add(Me.TotalPrice)
        Me.Controls.Add(Me.Interest)
        Me.Controls.Add(Me.YearsToPay)
        Me.Controls.Add(Me.Price)
        Me.Controls.Add(Me.Buy)
        Me.Controls.Add(Me.Car)
        Me.Controls.Add(Me.CarBrand)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CarMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Car Dealership App"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.CarBrand1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CarBrand0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CarPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CarBrand As ComboBox
    Friend WithEvents Car As ComboBox
    Friend WithEvents Price As TextBox
    Friend WithEvents YearsToPay As TextBox
    Friend WithEvents Interest As TextBox
    Friend WithEvents TotalPrice As TextBox
    Friend WithEvents MonthlyDue As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Buy As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Reset As Button
    Friend WithEvents CarPic As PictureBox
    Friend WithEvents CarBrand0 As PictureBox
    Friend WithEvents CarBrand1 As PictureBox
End Class
