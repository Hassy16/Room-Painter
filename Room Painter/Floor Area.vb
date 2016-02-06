Public Class frm_Floor_Area


    Private Sub frm_Floor_Area_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Disable Calculate Button
        btn_Calculate.Enabled = False

        'Hide Calculated Area Labels
        lbl_Total_Area.Hide()
        lbl_Area.Hide()
        lbl_Units_Squared.Hide()

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

    Private Sub Validity()

        'Check if combo box contain a valid measurement.
        With cmb_Unit_Measurement

            If .Text = "Centimetres" Or .Text = "Foot" Or .Text = "Inches" Or .Text = "Metres" Or .Text = "Yards" Then

                'Then check if all numbers entered are valid, if yes then enable Calculate button.
                If IsNumeric(txt_Length.Text) And IsNumeric(txt_Width.Text) Then

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
        Dim dec_Area As Decimal

        'Input Values
        dec_Length = txt_Length.Text
        dec_Width = txt_Width.Text

        'Calculate Area
        dec_Area = dec_Length * dec_Width

        'Output
        lbl_Area.Text = dec_Area.ToString
        lbl_Units_Squared.Text = cmb_Unit_Measurement.Text & " Squared"

        'Show Calculated Area Labels
        lbl_Total_Area.Show()
        lbl_Area.Show()
        lbl_Units_Squared.Show()

        'Clear text boxes and re-enable.
        Call Reset_Conversions()

#Region "Choose Conversion Module Sub"

        'Call Conversions Module Sub depending on units of measure.
        'Send a copy of the area value into the sub.
        Select Case cmb_Unit_Measurement.Text

            'Centimetres
            Case "Centimetres"

                Call Floor_Area_Centimetres(dec_Area)

            'Foot
            Case "Foot"

                Call Floor_Area_Foot(dec_Area)

            'Inches
            Case "Inches"

                Call Floor_Area_Inches(dec_Area)

            'Metres
            Case "Metres"

                Call Floor_Area_Metres(dec_Area)

            'Yards
            Case "Yards"

                Call Floor_Area_Yards(dec_Area)

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

        'If Yes, then Close and Dispose Floor Area UI and show Main UI.
        If msgrslt_Close = vbYes Then

            Close()
            Dispose()
            frm_Main.Show()

        End If

    End Sub


End Class