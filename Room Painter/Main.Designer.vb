<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Main
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
        Me.btn_Floor_Area = New System.Windows.Forms.Button()
        Me.btn_Paint_Requirements = New System.Windows.Forms.Button()
        Me.btn_Room_Volume = New System.Windows.Forms.Button()
        Me.btn_About = New System.Windows.Forms.Button()
        Me.btn_Exit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_Floor_Area
        '
        Me.btn_Floor_Area.Location = New System.Drawing.Point(12, 12)
        Me.btn_Floor_Area.Name = "btn_Floor_Area"
        Me.btn_Floor_Area.Size = New System.Drawing.Size(143, 28)
        Me.btn_Floor_Area.TabIndex = 1
        Me.btn_Floor_Area.Text = "Floor Area"
        Me.btn_Floor_Area.UseVisualStyleBackColor = True
        '
        'btn_Paint_Requirements
        '
        Me.btn_Paint_Requirements.Location = New System.Drawing.Point(162, 12)
        Me.btn_Paint_Requirements.Name = "btn_Paint_Requirements"
        Me.btn_Paint_Requirements.Size = New System.Drawing.Size(143, 28)
        Me.btn_Paint_Requirements.TabIndex = 2
        Me.btn_Paint_Requirements.Text = "Paint Requirements"
        Me.btn_Paint_Requirements.UseVisualStyleBackColor = True
        '
        'btn_Room_Volume
        '
        Me.btn_Room_Volume.Location = New System.Drawing.Point(84, 46)
        Me.btn_Room_Volume.Name = "btn_Room_Volume"
        Me.btn_Room_Volume.Size = New System.Drawing.Size(143, 28)
        Me.btn_Room_Volume.TabIndex = 3
        Me.btn_Room_Volume.Text = "Room Volume"
        Me.btn_Room_Volume.UseVisualStyleBackColor = True
        '
        'btn_About
        '
        Me.btn_About.Location = New System.Drawing.Point(12, 117)
        Me.btn_About.Name = "btn_About"
        Me.btn_About.Size = New System.Drawing.Size(143, 28)
        Me.btn_About.TabIndex = 4
        Me.btn_About.Text = "About"
        Me.btn_About.UseVisualStyleBackColor = True
        '
        'btn_Exit
        '
        Me.btn_Exit.Location = New System.Drawing.Point(162, 117)
        Me.btn_Exit.Name = "btn_Exit"
        Me.btn_Exit.Size = New System.Drawing.Size(143, 28)
        Me.btn_Exit.TabIndex = 5
        Me.btn_Exit.Text = "Exit"
        Me.btn_Exit.UseVisualStyleBackColor = True
        '
        'frm_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(317, 157)
        Me.ControlBox = False
        Me.Controls.Add(Me.btn_Exit)
        Me.Controls.Add(Me.btn_About)
        Me.Controls.Add(Me.btn_Room_Volume)
        Me.Controls.Add(Me.btn_Paint_Requirements)
        Me.Controls.Add(Me.btn_Floor_Area)
        Me.Name = "frm_Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Room Painter"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_Floor_Area As Button
    Friend WithEvents btn_Paint_Requirements As Button
    Friend WithEvents btn_Room_Volume As Button
    Friend WithEvents btn_About As Button
    Friend WithEvents btn_Exit As Button
End Class
