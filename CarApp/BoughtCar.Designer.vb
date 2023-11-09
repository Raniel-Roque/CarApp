<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BoughtCar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BoughtCar))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Name = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PhoneNum = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Email = New System.Windows.Forms.TextBox()
        Me.Address = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Reset = New System.Windows.Forms.Button()
        Me.NextPage = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Myanmar Text", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(55, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 30)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Name:"
        '
        'Name
        '
        Me.Name.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name.Location = New System.Drawing.Point(124, 131)
        Me.Name.Name = "Name"
        Me.Name.Size = New System.Drawing.Size(199, 26)
        Me.Name.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Myanmar Text", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(2, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(191, 37)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Basic Information"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Myanmar Text", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(9, 164)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 30)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Phone Num:"
        '
        'PhoneNum
        '
        Me.PhoneNum.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PhoneNum.Location = New System.Drawing.Point(124, 163)
        Me.PhoneNum.MaxLength = 11
        Me.PhoneNum.Name = "PhoneNum"
        Me.PhoneNum.Size = New System.Drawing.Size(199, 26)
        Me.PhoneNum.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Myanmar Text", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(60, 195)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 30)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Email:"
        '
        'Email
        '
        Me.Email.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Email.Location = New System.Drawing.Point(124, 195)
        Me.Email.Name = "Email"
        Me.Email.Size = New System.Drawing.Size(199, 26)
        Me.Email.TabIndex = 18
        '
        'Address
        '
        Me.Address.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Address.Location = New System.Drawing.Point(124, 227)
        Me.Address.Name = "Address"
        Me.Address.Size = New System.Drawing.Size(199, 26)
        Me.Address.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Myanmar Text", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(41, 227)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 30)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Address:"
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
        Me.Reset.Location = New System.Drawing.Point(124, 262)
        Me.Reset.Name = "Reset"
        Me.Reset.Size = New System.Drawing.Size(95, 30)
        Me.Reset.TabIndex = 22
        Me.Reset.Text = "Reset"
        Me.Reset.UseVisualStyleBackColor = False
        '
        'NextPage
        '
        Me.NextPage.BackColor = System.Drawing.Color.LightGreen
        Me.NextPage.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.NextPage.FlatAppearance.BorderSize = 2
        Me.NextPage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen
        Me.NextPage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.NextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NextPage.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NextPage.Location = New System.Drawing.Point(228, 262)
        Me.NextPage.Name = "NextPage"
        Me.NextPage.Size = New System.Drawing.Size(95, 30)
        Me.NextPage.TabIndex = 21
        Me.NextPage.Text = "Next"
        Me.NextPage.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Black
        Me.Label6.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(12, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 21)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Car Dealership"
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
        Me.MenuStrip1.Size = New System.Drawing.Size(335, 32)
        Me.MenuStrip1.TabIndex = 23
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
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CarApp.My.Resources.Resources.CAR_RECEIPT
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 28)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(339, 69)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'BoughtCar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(335, 308)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Reset)
        Me.Controls.Add(Me.NextPage)
        Me.Controls.Add(Me.Address)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Email)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PhoneNum)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Name)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label5)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Car Receipt"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Name As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PhoneNum As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Email As TextBox
    Friend WithEvents Address As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Reset As Button
    Friend WithEvents NextPage As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
End Class
