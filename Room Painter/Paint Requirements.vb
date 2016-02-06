Public Class frm_Paint_Requirements

    Private Sub frm_Paint_Requirements_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Disable Calculate Button
        btn_Calculate.Enabled = False

        'Hide Calculations Group Box
        grp_Calculations.Hide()

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

    Private Sub txt_Paint_Coatings_TextChanged(sender As Object, e As EventArgs) Handles txt_Paint_Coatings.TextChanged

        'Call Validity Sub
        Call Validity()

    End Sub

    Private Sub txt_MetresSq_Litre_TextChanged(sender As Object, e As EventArgs) Handles txt_MetresSq_Litre.TextChanged

        'Call Validity Sub
        Call Validity()

    End Sub

    Private Sub Validity()

        'Check if combo box contain a valid measurement.
        With cmb_Unit_Measurement

            If .Text = "Centimetres" Or .Text = "Foot" Or .Text = "Inches" Or .Text = "Metres" Or .Text = "Yards" Then

                'Then check if all numbers entered are valid, if yes then enable Calculate button.
                If IsNumeric(txt_Length.Text) And IsNumeric(txt_Width.Text) _
                    And IsNumeric(txt_Paint_Coatings.Text) And IsNumeric(txt_MetresSq_Litre.Text) Then

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
        Dim str_Unit_Measurement As String
        Dim dec_Length As Decimal
        Dim dec_Width As Decimal
        Dim dec_Area As Decimal
        Dim dec_Meters_Area As Decimal
        Dim dec_Paint_Coatings As Decimal
        Dim dec_MetresSq_Litre As Decimal
        Dim dec_Paint_Required As Decimal

        'Input Values
        str_Unit_Measurement = cmb_Unit_Measurement.Text
        dec_Length = txt_Length.Text
        dec_Width = txt_Width.Text
        dec_Paint_Coatings = txt_Paint_Coatings.Text
        dec_MetresSq_Litre = txt_MetresSq_Litre.Text

        'Calculate Area
        dec_Area = dec_Length * dec_Width

#Region "Convert to Metres"

        'Convert to Metres Squared
        Select Case str_Unit_Measurement

            'Centimetres
            Case "Centimetres"
                dec_Meters_Area = dec_Area * 0.0001

            'Foot
            Case "Foot"
                dec_Meters_Area = dec_Area * 0.092903

            'Inches
            Case "Inches"
                dec_Meters_Area = dec_Area * 0.00064516

            'Metres
            Case "Metres"
                dec_Meters_Area = dec_Area

            'Yards
            Case "Yards"
                dec_Meters_Area = dec_Area * 0.836127

        End Select

#End Region

        'Paint Litres Required Calculation
        dec_Paint_Required = (dec_Meters_Area * dec_Paint_Coatings) / dec_MetresSq_Litre

        'Output
        lbl_Area.Text = dec_Area.ToString
        lbl_Units_Squared.Text = str_Unit_Measurement & " Squared"
        lbl_Area_Metres.Text = dec_Meters_Area.ToString
        'Round Litres required to 5 decimal places.
        lbl_Paint_Litres.Text = Math.Round(dec_Paint_Required, 5).ToString & " Litres"
        'Show Calculations Group Box
        grp_Calculations.Show()

    End Sub

    Private Sub btn_Help_Click(sender As Object, e As EventArgs) Handles btn_Help.Click

        'Show Help Message Box
        MsgBox("Paint Coatings:" & vbNewLine & "Enter how many coatings you intend to do." _
            & vbNewLine & vbNewLine _
            & "Meters Sq / Litre:" & vbNewLine & "This is typically found on the paint tin." _
            , vbInformation + vbOKOnly)

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