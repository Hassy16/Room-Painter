Public Class frm_Room_Volume


    Private Sub frm_Room_Volume_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Disable Calculate Button
        btn_Calculate.Enabled = False

        'Hide Calculated Area Labels
        lbl_Total_Volume.Hide()
        lbl_Volume.Hide()
        lbl_Units_Cubed.Hide()

    End Sub

    Private Sub cmb_Unit_Measurement_TextChanged(sender As Object, e As EventArgs) Handles cmb_Unit_Measurement.TextChanged

        'Call Validity Sub
        Call Validity()

    End Sub

    Private Sub txt_Length_TextChanged(sender As Object, e As EventArgs) Handles txt_Length.TextChanged

        'Call Validity Sub
        Call Validity()

    End Sub

    Private Sub txt_Width_TextChanged(sender As Object, e As EventArgs) Handles txt_Width.TextChanged

        'Call Validity Sub
        Call Validity()

    End Sub

    Private Sub txt_Height_TextChanged(sender As Object, e As EventArgs) Handles txt_Height.TextChanged

        'Call Validity Sub
        Call Validity()

    End Sub

    Private Sub Validity()

        'Check if combo box contain a valid measurement.
        With cmb_Unit_Measurement

            If .Text = "Centimetres" Or .Text = "Foot" Or .Text = "Inches" Or .Text = "Metres" Or .Text = "Yards" Then

                'Then check if all numbers entered are valid, if yes then enable Calculate button.
                If IsNumeric(txt_Length.Text) And IsNumeric(txt_Width.Text) And IsNumeric(txt_Height.Text) Then

                    btn_Calculate.Enabled = True

                End If

            Else
                'Else Disable Button
                btn_Calculate.Enabled = False

            End If

        End With

    End Sub

    Private Sub btn_Calculate_Click(sender As Object, e As EventArgs) Handles btn_Calculate.Click

        'Declare Variables
        Dim dec_Length As Decimal
        Dim dec_Width As Decimal
        Dim dec_Height As Decimal
        Dim dec_Volume As Decimal

        'Input Values
        dec_Length = txt_Length.Text
        dec_Width = txt_Width.Text
        dec_Height = txt_Height.Text

        'Calculate Volume
        dec_Volume = dec_Length * dec_Width * dec_Height

        'Output
        lbl_Volume.Text = dec_Volume.ToString
        lbl_Units_Cubed.Text = cmb_Unit_Measurement.Text & " Cubed"

        'Show Calculated Volume Labels
        lbl_Total_Volume.Show()
        lbl_Volume.Show()
        lbl_Units_Cubed.Show()

        'Clear text boxes and re-enable.
        Call Reset_Conversions()

#Region "Choose Conversion Module Sub"

        'Call Conversions Module Sub depending on units of measure.
        'Send a copy of the volume value into the sub.
        Select Case cmb_Unit_Measurement.Text

            'Centimetres
            Case "Centimetres"

                Call Room_Volume_Centimetres(dec_Volume)

            'Foot
            Case "Foot"

                Call Room_Volume_Foot(dec_Volume)

            'Inches
            Case "Inches"

                Call Room_Volume_Inches(dec_Volume)

            'Metres
            Case "Metres"

                Call Room_Volume_Metres(dec_Volume)

            'Yards
            Case "Yards"

                Call Room_Volume_Yards(dec_Volume)

        End Select

#End Region

    End Sub

    Private Sub Reset_Conversions()

        'This Sub clears all unit conversion text boxes and enables them.

        txt_Centimetres.Clear()
        txt_Foot.Clear()
        txt_Inches.Clear()
        txt_Metres.Clear()
        txt_Yards.Clear()

        txt_Centimetres.Enabled = True
        txt_Foot.Enabled = True
        txt_Inches.Enabled = True
        txt_Metres.Enabled = True
        txt_Yards.Enabled = True

    End Sub

    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click

        'Declare Variable
        Dim msgrslt_Close As MsgBoxResult

        'Show Message
        msgrslt_Close = MsgBox("Return to Main Menu", vbQuestion + vbYesNo)

        'If Yes, then Close and Dispose Room Volume UI and show Main UI.
        If msgrslt_Close = vbYes Then

            Close()
            Dispose()
            frm_Main.Show()

        End If

    End Sub


End Class