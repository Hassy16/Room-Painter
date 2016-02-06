<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Paint_Requirements
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
        Me.lbl_Paint_MetresSqL = New System.Windows.Forms.Label()
        Me.txt_MetresSq_Litre = New System.Windows.Forms.TextBox()
        Me.lbl_Paint_Coatings = New System.Windows.Forms.Label()
        Me.txt_Paint_Coatings = New System.Windows.Forms.TextBox()
        Me.lbl_Width = New System.Windows.Forms.Label()
        Me.lbl_Length = New System.Windows.Forms.Label()
        Me.txt_Width = New System.Windows.Forms.TextBox()
        Me.txt_Length = New System.Windows.Forms.TextBox()
        Me.lbl_Unit_Measurement = New System.Windows.Forms.Label()
        Me.cmb_Unit_Measurement = New System.Windows.Forms.ComboBox()
        Me.lbl_Total_Area = New System.Windows.Forms.Label()
        Me.btn_Calculate = New System.Windows.Forms.Button()
        Me.btn_Help = New System.Windows.Forms.Button()
        Me.lbl_Area = New System.Windows.Forms.Label()
        Me.lbl_Units_Squared = New System.Windows.Forms.Label()
        Me.grp_Calculations = New System.Windows.Forms.GroupBox()
        Me.lbl_Paint_Litres = New System.Windows.Forms.Label()
        Me.lbl_Paint_Required = New System.Windows.Forms.Label()
        Me.lbl_Area_Metres = New System.Windows.Forms.Label()
        Me.lbl_Area_In_Metres = New System.Windows.Forms.Label()
        Me.btn_Close = New System.Windows.Forms.Button()
        Me.grp_Dimensions.SuspendLayout()
        Me.grp_Calculations.SuspendLayout()
        Me.SuspendLayout()
        '
        'grp_Dimensions
        '
        Me.grp_Dimensions.Controls.Add(Me.lbl_Paint_MetresSqL)
        Me.grp_Dimensions.Controls.Add(Me.txt_MetresSq_Litre)
        Me.grp_Dimensions.Controls.Add(Me.lbl_Paint_Coatings)
        Me.grp_Dimensions.Controls.Add(Me.txt_Paint_Coatings)
        Me.grp_Dimensions.Controls.Add(Me.lbl_Width)
        Me.grp_Dimensions.Controls.Add(Me.lbl_Length)
        Me.grp_Dimensions.Controls.Add(Me.txt_Width)
        Me.grp_Dimensions.Controls.Add(Me.txt_Length)
        Me.grp_Dimensions.Controls.Add(Me.lbl_Unit_Measurement)
        Me.grp_Dimensions.Controls.Add(Me.cmb_Unit_Measurement)
        Me.grp_Dimensions.Location = New System.Drawing.Point(15, 12)
        Me.grp_Dimensions.Name = "grp_Dimensions"
        Me.grp_Dimensions.Size = New System.Drawing.Size(267, 192)
        Me.grp_Dimensions.TabIndex = 0
        Me.grp_Dimensions.TabStop = False
        Me.grp_Dimensions.Text = "Dimensions"
        '
        'lbl_Paint_MetresSqL
        '
        Me.lbl_Paint_MetresSqL.AutoSize = True
        Me.lbl_Paint_MetresSqL.Location = New System.Drawing.Point(17, 156)
        Me.lbl_Paint_MetresSqL.Name = "lbl_Paint_MetresSqL"
        Me.lbl_Paint_MetresSqL.Size = New System.Drawing.Size(112, 17)
        Me.lbl_Paint_MetresSqL.TabIndex = 12
        Me.lbl_Paint_MetresSqL.Text = "Metres Sq / Litre"
        '
        'txt_MetresSq_Litre
        '
        Me.txt_MetresSq_Litre.Location = New System.Drawing.Point(135, 153)
        Me.txt_MetresSq_Litre.Name = "txt_MetresSq_Litre"
        Me.txt_MetresSq_Litre.Size = New System.Drawing.Size(100, 22)
        Me.txt_MetresSq_Litre.TabIndex = 5
        '
        'lbl_Paint_Coatings
        '
        Me.lbl_Paint_Coatings.AutoSize = True
        Me.lbl_Paint_Coatings.Location = New System.Drawing.Point(30, 128)
        Me.lbl_Paint_Coatings.Name = "lbl_Paint_Coatings"
        Me.lbl_Paint_Coatings.Size = New System.Drawing.Size(99, 17)
        Me.lbl_Paint_Coatings.TabIndex = 11
        Me.lbl_Paint_Coatings.Text = "Paint Coatings"
        '
        'txt_Paint_Coatings
        '
        Me.txt_Paint_Coatings.Location = New System.Drawing.Point(135, 125)
        Me.txt_Paint_Coatings.Name = "txt_Paint_Coatings"
        Me.txt_Paint_Coatings.Size = New System.Drawing.Size(100, 22)
        Me.txt_Paint_Coatings.TabIndex = 4
        '
        'lbl_Width
        '
        Me.lbl_Width.AutoSize = True
        Me.lbl_Width.Location = New System.Drawing.Point(85, 91)
        Me.lbl_Width.Name = "lbl_Width"
        Me.lbl_Width.Size = New System.Drawing.Size(44, 17)
        Me.lbl_Width.TabIndex = 7
        Me.lbl_Width.Text = "Width"
        '
        'lbl_Length
        '
        Me.lbl_Length.AutoSize = True
        Me.lbl_Length.Location = New System.Drawing.Point(77, 63)
        Me.lbl_Length.Name = "lbl_Length"
        Me.lbl_Length.Size = New System.Drawing.Size(52, 17)
        Me.lbl_Length.TabIndex = 6
        Me.lbl_Length.Text = "Length"
        '
        'txt_Width
        '
        Me.txt_Width.Location = New System.Drawing.Point(135, 88)
        Me.txt_Width.Name = "txt_Width"
        Me.txt_Width.Size = New System.Drawing.Size(100, 22)
        Me.txt_Width.TabIndex = 3
        '
        'txt_Length
        '
        Me.txt_Length.Location = New System.Drawing.Point(135, 60)
        Me.txt_Length.Name = "txt_Length"
        Me.txt_Length.Size = New System.Drawing.Size(100, 22)
        Me.txt_Length.TabIndex = 2
        '
        'lbl_Unit_Measurement
        '
        Me.lbl_Unit_Measurement.AutoSize = True
        Me.lbl_Unit_Measurement.Location = New System.Drawing.Point(6, 24)
        Me.lbl_Unit_Measurement.Name = "lbl_Unit_Measurement"
        Me.lbl_Unit_Measurement.Size = New System.Drawing.Size(123, 17)
        Me.lbl_Unit_Measurement.TabIndex = 1
        Me.lbl_Unit_Measurement.Text = "Unit Measurement"
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
        'lbl_Total_Area
        '
        Me.lbl_Total_Area.AutoSize = True
        Me.lbl_Total_Area.Location = New System.Drawing.Point(34, 18)
        Me.lbl_Total_Area.Name = "lbl_Total_Area"
        Me.lbl_Total_Area.Size = New System.Drawing.Size(78, 17)
        Me.lbl_Total_Area.TabIndex = 1
        Me.lbl_Total_Area.Text = "Total Area:"
        '
        'btn_Calculate
        '
        Me.btn_Calculate.Location = New System.Drawing.Point(15, 345)
        Me.btn_Calculate.Name = "btn_Calculate"
        Me.btn_Calculate.Size = New System.Drawing.Size(85, 28)
        Me.btn_Calculate.TabIndex = 6
        Me.btn_Calculate.Text = "Calculate"
        Me.btn_Calculate.UseVisualStyleBackColor = True
        '
        'btn_Help
        '
        Me.btn_Help.Location = New System.Drawing.Point(106, 345)
        Me.btn_Help.Name = "btn_Help"
        Me.btn_Help.Size = New System.Drawing.Size(85, 28)
        Me.btn_Help.TabIndex = 7
        Me.btn_Help.Text = "Help"
        Me.btn_Help.UseVisualStyleBackColor = True
        '
        'lbl_Area
        '
        Me.lbl_Area.AutoSize = True
        Me.lbl_Area.Location = New System.Drawing.Point(118, 18)
        Me.lbl_Area.Name = "lbl_Area"
        Me.lbl_Area.Size = New System.Drawing.Size(51, 17)
        Me.lbl_Area.TabIndex = 5
        Me.lbl_Area.Text = "Label1"
        '
        'lbl_Units_Squared
        '
        Me.lbl_Units_Squared.AutoSize = True
        Me.lbl_Units_Squared.Location = New System.Drawing.Point(118, 35)
        Me.lbl_Units_Squared.Name = "lbl_Units_Squared"
        Me.lbl_Units_Squared.Size = New System.Drawing.Size(51, 17)
        Me.lbl_Units_Squared.TabIndex = 6
        Me.lbl_Units_Squared.Text = "Label1"
        '
        'grp_Calculations
        '
        Me.grp_Calculations.Controls.Add(Me.lbl_Paint_Litres)
        Me.grp_Calculations.Controls.Add(Me.lbl_Paint_Required)
        Me.grp_Calculations.Controls.Add(Me.lbl_Area_Metres)
        Me.grp_Calculations.Controls.Add(Me.lbl_Area_In_Metres)
        Me.grp_Calculations.Controls.Add(Me.lbl_Total_Area)
        Me.grp_Calculations.Controls.Add(Me.lbl_Units_Squared)
        Me.grp_Calculations.Controls.Add(Me.lbl_Area)
        Me.grp_Calculations.Location = New System.Drawing.Point(15, 210)
        Me.grp_Calculations.Name = "grp_Calculations"
        Me.grp_Calculations.Size = New System.Drawing.Size(267, 120)
        Me.grp_Calculations.TabIndex = 7
        Me.grp_Calculations.TabStop = False
        Me.grp_Calculations.Text = "Calculations"
        '
        'lbl_Paint_Litres
        '
        Me.lbl_Paint_Litres.AutoSize = True
        Me.lbl_Paint_Litres.Location = New System.Drawing.Point(118, 90)
        Me.lbl_Paint_Litres.Name = "lbl_Paint_Litres"
        Me.lbl_Paint_Litres.Size = New System.Drawing.Size(51, 17)
        Me.lbl_Paint_Litres.TabIndex = 10
        Me.lbl_Paint_Litres.Text = "Label1"
        '
        'lbl_Paint_Required
        '
        Me.lbl_Paint_Required.AutoSize = True
        Me.lbl_Paint_Required.Location = New System.Drawing.Point(6, 90)
        Me.lbl_Paint_Required.Name = "lbl_Paint_Required"
        Me.lbl_Paint_Required.Size = New System.Drawing.Size(106, 17)
        Me.lbl_Paint_Required.TabIndex = 9
        Me.lbl_Paint_Required.Text = "Paint Required:"
        '
        'lbl_Area_Metres
        '
        Me.lbl_Area_Metres.AutoSize = True
        Me.lbl_Area_Metres.Location = New System.Drawing.Point(118, 62)
        Me.lbl_Area_Metres.Name = "lbl_Area_Metres"
        Me.lbl_Area_Metres.Size = New System.Drawing.Size(51, 17)
        Me.lbl_Area_Metres.TabIndex = 8
        Me.lbl_Area_Metres.Text = "Label1"
        '
        'lbl_Area_In_Metres
        '
        Me.lbl_Area_In_Metres.AutoSize = True
        Me.lbl_Area_In_Metres.Location = New System.Drawing.Point(8, 62)
        Me.lbl_Area_In_Metres.Name = "lbl_Area_In_Metres"
        Me.lbl_Area_In_Metres.Size = New System.Drawing.Size(104, 17)
        Me.lbl_Area_In_Metres.TabIndex = 7
        Me.lbl_Area_In_Metres.Text = "Area In Metres:"
        '
        'btn_Close
        '
        Me.btn_Close.Location = New System.Drawing.Point(197, 345)
        Me.btn_Close.Name = "btn_Close"
        Me.btn_Close.Size = New System.Drawing.Size(85, 28)
        Me.btn_Close.TabIndex = 8
        Me.btn_Close.Text = "Close"
        Me.btn_Close.UseVisualStyleBackColor = True
        '
        'frm_Paint_Requirements
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(298, 386)
        Me.ControlBox = False
        Me.Controls.Add(Me.btn_Close)
        Me.Controls.Add(Me.grp_Calculations)
        Me.Controls.Add(Me.btn_Help)
        Me.Controls.Add(Me.btn_Calculate)
        Me.Controls.Add(Me.grp_Dimensions)
        Me.Name = "frm_Paint_Requirements"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Paint Requirements"
        Me.grp_Dimensions.ResumeLayout(False)
        Me.grp_Dimensions.PerformLayout()
        Me.grp_Calculations.ResumeLayout(False)
        Me.grp_Calculations.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grp_Dimensions As GroupBox
    Friend WithEvents lbl_Unit_Measurement As Label
    Friend WithEvents cmb_Unit_Measurement As ComboBox
    Friend WithEvents lbl_Width As Label
    Friend WithEvents lbl_Length As Label
    Friend WithEvents txt_Width As TextBox
    Friend WithEvents txt_Length As TextBox
    Friend WithEvents lbl_Paint_MetresSqL As Label
    Friend WithEvents txt_MetresSq_Litre As TextBox
    Friend WithEvents lbl_Paint_Coatings As Label
    Friend WithEvents txt_Paint_Coatings As TextBox
    Friend WithEvents lbl_Total_Area As Label
    Friend WithEvents btn_Calculate As Button
    Friend WithEvents btn_Help As Button
    Friend WithEvents lbl_Area As Label
    Friend WithEvents lbl_Units_Squared As Label
    Friend WithEvents grp_Calculations As GroupBox
    Friend WithEvents lbl_Paint_Required As Label
    Friend WithEvents lbl_Area_Metres As Label
    Friend WithEvents lbl_Area_In_Metres As Label
    Friend WithEvents btn_Close As Button
    Friend WithEvents lbl_Paint_Litres As Label
End Class
