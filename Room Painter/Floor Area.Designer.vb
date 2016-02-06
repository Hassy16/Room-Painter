<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Floor_Area
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
        Me.grp_Dimensions = New System.Windows.Forms.GroupBox()
        Me.lbl_Width = New System.Windows.Forms.Label()
        Me.lbl_Length = New System.Windows.Forms.Label()
        Me.txt_Width = New System.Windows.Forms.TextBox()
        Me.txt_Length = New System.Windows.Forms.TextBox()
        Me.cmb_Unit_Measurement = New System.Windows.Forms.ComboBox()
        Me.lbl_Unit_Measurement = New System.Windows.Forms.Label()
        Me.lbl_Units_Squared = New System.Windows.Forms.Label()
        Me.lbl_Area = New System.Windows.Forms.Label()
        Me.lbl_Total_Area = New System.Windows.Forms.Label()
        Me.grp_Unit_Conversions = New System.Windows.Forms.GroupBox()
        Me.lbl_Yards = New System.Windows.Forms.Label()
        Me.lbl_Metres = New System.Windows.Forms.Label()
        Me.lbl_Inches = New System.Windows.Forms.Label()
        Me.txt_Inches = New System.Windows.Forms.TextBox()
        Me.txt_Metres = New System.Windows.Forms.TextBox()
        Me.txt_Yards = New System.Windows.Forms.TextBox()
        Me.txt_Foot = New System.Windows.Forms.TextBox()
        Me.lbl_Foot = New System.Windows.Forms.Label()
        Me.txt_Centimetres = New System.Windows.Forms.TextBox()
        Me.lbl_Centimetres = New System.Windows.Forms.Label()
        Me.btn_Calculate = New System.Windows.Forms.Button()
        Me.btn_Close = New System.Windows.Forms.Button()
        Me.grp_Dimensions.SuspendLayout()
        Me.grp_Unit_Conversions.SuspendLayout()
        Me.SuspendLayout()
        '
        'grp_Dimensions
        '
        Me.grp_Dimensions.Controls.Add(Me.lbl_Width)
        Me.grp_Dimensions.Controls.Add(Me.lbl_Length)
        Me.grp_Dimensions.Controls.Add(Me.txt_Width)
        Me.grp_Dimensions.Controls.Add(Me.txt_Length)
        Me.grp_Dimensions.Controls.Add(Me.cmb_Unit_Measurement)
        Me.grp_Dimensions.Controls.Add(Me.lbl_Unit_Measurement)
        Me.grp_Dimensions.Location = New System.Drawing.Point(12, 12)
        Me.grp_Dimensions.Name = "grp_Dimensions"
        Me.grp_Dimensions.Size = New System.Drawing.Size(266, 125)
        Me.grp_Dimensions.TabIndex = 0
        Me.grp_Dimensions.TabStop = False
        Me.grp_Dimensions.Text = "Dimensions"
        '
        'lbl_Width
        '
        Me.lbl_Width.AutoSize = True
        Me.lbl_Width.Location = New System.Drawing.Point(85, 92)
        Me.lbl_Width.Name = "lbl_Width"
        Me.lbl_Width.Size = New System.Drawing.Size(44, 17)
        Me.lbl_Width.TabIndex = 3
        Me.lbl_Width.Text = "Width"
        '
        'lbl_Length
        '
        Me.lbl_Length.AutoSize = True
        Me.lbl_Length.Location = New System.Drawing.Point(77, 64)
        Me.lbl_Length.Name = "lbl_Length"
        Me.lbl_Length.Size = New System.Drawing.Size(52, 17)
        Me.lbl_Length.TabIndex = 2
        Me.lbl_Length.Text = "Length"
        '
        'txt_Width
        '
        Me.txt_Width.Location = New System.Drawing.Point(135, 89)
        Me.txt_Width.Name = "txt_Width"
        Me.txt_Width.Size = New System.Drawing.Size(100, 22)
        Me.txt_Width.TabIndex = 3
        '
        'txt_Length
        '
        Me.txt_Length.Location = New System.Drawing.Point(135, 61)
        Me.txt_Length.Name = "txt_Length"
        Me.txt_Length.Size = New System.Drawing.Size(100, 22)
        Me.txt_Length.TabIndex = 2
        '
        'cmb_Unit_Measurement
        '
        Me.cmb_Unit_Measurement.FormattingEnabled = True
        Me.cmb_Unit_Measurement.Items.AddRange(New Object() {"Centimetres", "Foot", "Inches", "Metres", "Yards"})
        Me.cmb_Unit_Measurement.Location = New System.Drawing.Point(135, 21)
        Me.cmb_Unit_Measurement.Name = "cmb_Unit_Measurement"
        Me.cmb_Unit_Measurement.Size = New System.Drawing.Size(121, 24)
        Me.cmb_Unit_Measurement.TabIndex = 1
        '
        'lbl_Unit_Measurement
        '
        Me.lbl_Unit_Measurement.AutoSize = True
        Me.lbl_Unit_Measurement.Location = New System.Drawing.Point(6, 24)
        Me.lbl_Unit_Measurement.Name = "lbl_Unit_Measurement"
        Me.lbl_Unit_Measurement.Size = New System.Drawing.Size(123, 17)
        Me.lbl_Unit_Measurement.TabIndex = 0
        Me.lbl_Unit_Measurement.Text = "Unit Measurement"
        '
        'lbl_Units_Squared
        '
        Me.lbl_Units_Squared.AutoSize = True
        Me.lbl_Units_Squared.Location = New System.Drawing.Point(144, 164)
        Me.lbl_Units_Squared.Name = "lbl_Units_Squared"
        Me.lbl_Units_Squared.Size = New System.Drawing.Size(51, 17)
        Me.lbl_Units_Squared.TabIndex = 8
        Me.lbl_Units_Squared.Text = "Label1"
        '
        'lbl_Area
        '
        Me.lbl_Area.AutoSize = True
        Me.lbl_Area.Location = New System.Drawing.Point(144, 145)
        Me.lbl_Area.Name = "lbl_Area"
        Me.lbl_Area.Size = New System.Drawing.Size(51, 17)
        Me.lbl_Area.TabIndex = 7
        Me.lbl_Area.Text = "Label1"
        '
        'lbl_Total_Area
        '
        Me.lbl_Total_Area.AutoSize = True
        Me.lbl_Total_Area.Location = New System.Drawing.Point(63, 145)
        Me.lbl_Total_Area.Name = "lbl_Total_Area"
        Me.lbl_Total_Area.Size = New System.Drawing.Size(78, 17)
        Me.lbl_Total_Area.TabIndex = 6
        Me.lbl_Total_Area.Text = "Total Area:"
        '
        'grp_Unit_Conversions
        '
        Me.grp_Unit_Conversions.Controls.Add(Me.lbl_Yards)
        Me.grp_Unit_Conversions.Controls.Add(Me.lbl_Metres)
        Me.grp_Unit_Conversions.Controls.Add(Me.lbl_Inches)
        Me.grp_Unit_Conversions.Controls.Add(Me.txt_Inches)
        Me.grp_Unit_Conversions.Controls.Add(Me.txt_Metres)
        Me.grp_Unit_Conversions.Controls.Add(Me.txt_Yards)
        Me.grp_Unit_Conversions.Controls.Add(Me.txt_Foot)
        Me.grp_Unit_Conversions.Controls.Add(Me.lbl_Foot)
        Me.grp_Unit_Conversions.Controls.Add(Me.txt_Centimetres)
        Me.grp_Unit_Conversions.Controls.Add(Me.lbl_Centimetres)
        Me.grp_Unit_Conversions.Location = New System.Drawing.Point(284, 12)
        Me.grp_Unit_Conversions.Name = "grp_Unit_Conversions"
        Me.grp_Unit_Conversions.Size = New System.Drawing.Size(208, 169)
        Me.grp_Unit_Conversions.TabIndex = 1
        Me.grp_Unit_Conversions.TabStop = False
        Me.grp_Unit_Conversions.Text = "Unit Conversions"
        '
        'lbl_Yards
        '
        Me.lbl_Yards.AutoSize = True
        Me.lbl_Yards.Location = New System.Drawing.Point(6, 136)
        Me.lbl_Yards.Name = "lbl_Yards"
        Me.lbl_Yards.Size = New System.Drawing.Size(45, 17)
        Me.lbl_Yards.TabIndex = 9
        Me.lbl_Yards.Text = "Yards"
        '
        'lbl_Metres
        '
        Me.lbl_Metres.AutoSize = True
        Me.lbl_Metres.Location = New System.Drawing.Point(6, 108)
        Me.lbl_Metres.Name = "lbl_Metres"
        Me.lbl_Metres.Size = New System.Drawing.Size(51, 17)
        Me.lbl_Metres.TabIndex = 8
        Me.lbl_Metres.Text = "Metres"
        '
        'lbl_Inches
        '
        Me.lbl_Inches.AutoSize = True
        Me.lbl_Inches.Location = New System.Drawing.Point(6, 80)
        Me.lbl_Inches.Name = "lbl_Inches"
        Me.lbl_Inches.Size = New System.Drawing.Size(49, 17)
        Me.lbl_Inches.TabIndex = 7
        Me.lbl_Inches.Text = "Inches"
        '
        'txt_Inches
        '
        Me.txt_Inches.Location = New System.Drawing.Point(95, 77)
        Me.txt_Inches.Name = "txt_Inches"
        Me.txt_Inches.ReadOnly = True
        Me.txt_Inches.Size = New System.Drawing.Size(100, 22)
        Me.txt_Inches.TabIndex = 7
        '
        'txt_Metres
        '
        Me.txt_Metres.Location = New System.Drawing.Point(95, 105)
        Me.txt_Metres.Name = "txt_Metres"
        Me.txt_Metres.ReadOnly = True
        Me.txt_Metres.Size = New System.Drawing.Size(100, 22)
        Me.txt_Metres.TabIndex = 8
        '
        'txt_Yards
        '
        Me.txt_Yards.Location = New System.Drawing.Point(95, 133)
        Me.txt_Yards.Name = "txt_Yards"
        Me.txt_Yards.ReadOnly = True
        Me.txt_Yards.Size = New System.Drawing.Size(100, 22)
        Me.txt_Yards.TabIndex = 9
        '
        'txt_Foot
        '
        Me.txt_Foot.Location = New System.Drawing.Point(95, 49)
        Me.txt_Foot.Name = "txt_Foot"
        Me.txt_Foot.ReadOnly = True
        Me.txt_Foot.Size = New System.Drawing.Size(100, 22)
        Me.txt_Foot.TabIndex = 6
        '
        'lbl_Foot
        '
        Me.lbl_Foot.AutoSize = True
        Me.lbl_Foot.Location = New System.Drawing.Point(6, 52)
        Me.lbl_Foot.Name = "lbl_Foot"
        Me.lbl_Foot.Size = New System.Drawing.Size(36, 17)
        Me.lbl_Foot.TabIndex = 2
        Me.lbl_Foot.Text = "Foot"
        '
        'txt_Centimetres
        '
        Me.txt_Centimetres.Location = New System.Drawing.Point(95, 21)
        Me.txt_Centimetres.Name = "txt_Centimetres"
        Me.txt_Centimetres.ReadOnly = True
        Me.txt_Centimetres.Size = New System.Drawing.Size(100, 22)
        Me.txt_Centimetres.TabIndex = 5
        '
        'lbl_Centimetres
        '
        Me.lbl_Centimetres.AutoSize = True
        Me.lbl_Centimetres.Location = New System.Drawing.Point(6, 24)
        Me.lbl_Centimetres.Name = "lbl_Centimetres"
        Me.lbl_Centimetres.Size = New System.Drawing.Size(83, 17)
        Me.lbl_Centimetres.TabIndex = 0
        Me.lbl_Centimetres.Text = "Centimetres"
        '
        'btn_Calculate
        '
        Me.btn_Calculate.Location = New System.Drawing.Point(12, 196)
        Me.btn_Calculate.Name = "btn_Calculate"
        Me.btn_Calculate.Size = New System.Drawing.Size(143, 28)
        Me.btn_Calculate.TabIndex = 4
        Me.btn_Calculate.Text = "Calculate"
        Me.btn_Calculate.UseVisualStyleBackColor = True
        '
        'btn_Close
        '
        Me.btn_Close.Location = New System.Drawing.Point(351, 196)
        Me.btn_Close.Name = "btn_Close"
        Me.btn_Close.Size = New System.Drawing.Size(143, 28)
        Me.btn_Close.TabIndex = 10
        Me.btn_Close.Text = "Close"
        Me.btn_Close.UseVisualStyleBackColor = True
        '
        'frm_Floor_Area
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(508, 238)
        Me.ControlBox = False
        Me.Controls.Add(Me.lbl_Total_Area)
        Me.Controls.Add(Me.lbl_Area)
        Me.Controls.Add(Me.lbl_Units_Squared)
        Me.Controls.Add(Me.btn_Close)
        Me.Controls.Add(Me.btn_Calculate)
        Me.Controls.Add(Me.grp_Unit_Conversions)
        Me.Controls.Add(Me.grp_Dimensions)
        Me.Name = "frm_Floor_Area"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Floor Area"
        Me.grp_Dimensions.ResumeLayout(False)
        Me.grp_Dimensions.PerformLayout()
        Me.grp_Unit_Conversions.ResumeLayout(False)
        Me.grp_Unit_Conversions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grp_Dimensions As GroupBox
    Friend WithEvents lbl_Total_Area As Label
    Friend WithEvents txt_Width As TextBox
    Friend WithEvents txt_Length As TextBox
    Friend WithEvents lbl_Width As Label
    Friend WithEvents lbl_Length As Label
    Friend WithEvents cmb_Unit_Measurement As ComboBox
    Friend WithEvents lbl_Unit_Measurement As Label
    Friend WithEvents grp_Unit_Conversions As GroupBox
    Friend WithEvents lbl_Yards As Label
    Friend WithEvents lbl_Metres As Label
    Friend WithEvents lbl_Inches As Label
    Friend WithEvents txt_Inches As TextBox
    Friend WithEvents txt_Metres As TextBox
    Friend WithEvents txt_Yards As TextBox
    Friend WithEvents txt_Foot As TextBox
    Friend WithEvents lbl_Foot As Label
    Friend WithEvents txt_Centimetres As TextBox
    Friend WithEvents lbl_Centimetres As Label
    Friend WithEvents btn_Calculate As Button
    Friend WithEvents btn_Close As Button
    Friend WithEvents lbl_Area As Label
    Friend WithEvents lbl_Units_Squared As Label
End Class
