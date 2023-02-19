<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAirBnB
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAirBnB))
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblNumNights = New System.Windows.Forms.Label()
        Me.txtNumberOfNights = New System.Windows.Forms.TextBox()
        Me.btnCost = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.picAirBnB = New System.Windows.Forms.PictureBox()
        Me.lblCostOfStay = New System.Windows.Forms.Label()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        CType(Me.picAirBnB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.BackColor = System.Drawing.Color.Transparent
        Me.lblHeading.Font = New System.Drawing.Font("Cooper Black", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(393, 29)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(411, 49)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "AirBnB Reservations"
        Me.lblHeading.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblPrice
        '
        Me.lblPrice.Font = New System.Drawing.Font("Cooper Black", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(447, 98)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(312, 37)
        Me.lblPrice.TabIndex = 1
        Me.lblPrice.Text = "Only $79 per Night!"
        Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblNumNights
        '
        Me.lblNumNights.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumNights.Location = New System.Drawing.Point(427, 185)
        Me.lblNumNights.Name = "lblNumNights"
        Me.lblNumNights.Size = New System.Drawing.Size(203, 33)
        Me.lblNumNights.TabIndex = 2
        Me.lblNumNights.Text = "Number of Nights:"
        '
        'txtNumberOfNights
        '
        Me.txtNumberOfNights.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumberOfNights.Location = New System.Drawing.Point(652, 185)
        Me.txtNumberOfNights.Multiline = True
        Me.txtNumberOfNights.Name = "txtNumberOfNights"
        Me.txtNumberOfNights.Size = New System.Drawing.Size(48, 33)
        Me.txtNumberOfNights.TabIndex = 3
        '
        'btnCost
        '
        Me.btnCost.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.btnCost.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCost.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCost.Location = New System.Drawing.Point(415, 353)
        Me.btnCost.Name = "btnCost"
        Me.btnCost.Size = New System.Drawing.Size(111, 36)
        Me.btnCost.TabIndex = 4
        Me.btnCost.Text = "Display Cost"
        Me.btnCost.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(546, 353)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(111, 36)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(677, 353)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(111, 36)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'picAirBnB
        '
        Me.picAirBnB.Image = CType(resources.GetObject("picAirBnB.Image"), System.Drawing.Image)
        Me.picAirBnB.Location = New System.Drawing.Point(2, 2)
        Me.picAirBnB.Name = "picAirBnB"
        Me.picAirBnB.Size = New System.Drawing.Size(394, 447)
        Me.picAirBnB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAirBnB.TabIndex = 7
        Me.picAirBnB.TabStop = False
        '
        'lblCostOfStay
        '
        Me.lblCostOfStay.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostOfStay.Location = New System.Drawing.Point(427, 266)
        Me.lblCostOfStay.Name = "lblCostOfStay"
        Me.lblCostOfStay.Size = New System.Drawing.Size(194, 32)
        Me.lblCostOfStay.TabIndex = 8
        Me.lblCostOfStay.Text = "Cost of Stay:"
        '
        'lblTotalCost
        '
        Me.lblTotalCost.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCost.Location = New System.Drawing.Point(652, 266)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(98, 32)
        Me.lblTotalCost.TabIndex = 9
        Me.lblTotalCost.Text = "$888.88"
        Me.lblTotalCost.Visible = False
        '
        'frmAirBnB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkKhaki
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.lblCostOfStay)
        Me.Controls.Add(Me.picAirBnB)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCost)
        Me.Controls.Add(Me.txtNumberOfNights)
        Me.Controls.Add(Me.lblNumNights)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "frmAirBnB"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AirBnB Reservations"
        CType(Me.picAirBnB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblNumNights As Label
    Friend WithEvents txtNumberOfNights As TextBox
    Friend WithEvents btnCost As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents picAirBnB As PictureBox
    Friend WithEvents lblCostOfStay As Label
    Friend WithEvents lblTotalCost As Label
End Class
