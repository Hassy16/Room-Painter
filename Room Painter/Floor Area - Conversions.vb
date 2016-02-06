Module Floor_Area_Conversions

#Region "Module Variables"

    'Declare Module Variables
    Dim dec_Centimetres As Decimal
    Dim dec_Foot As Decimal
    Dim dec_Inches As Decimal
    Dim dec_Metres As Decimal
    Dim dec_Yards As Decimal

#End Region

    'ByVal Area creates a variable so that a copy of the area value can be sent to the sub.

    Public Sub Floor_Area_Centimetres(ByVal Area)

        With frm_Floor_Area

            'Disable Centimetres Text Box
            .txt_Centimetres.Enabled = False

            'Convert Centimeters to other units.
            dec_Foot = Area * 0.00107639
            dec_Inches = Area * 0.155
            dec_Metres = Area * 0.0001
            dec_Yards = Area * 0.000119599

            'Output
            .txt_Foot.Text = dec_Foot.ToString
            .txt_Inches.Text = dec_Inches.ToString
            .txt_Metres.Text = dec_Metres.ToString
            .txt_Yards.Text = dec_Yards.ToString

        End With

    End Sub

    Public Sub Floor_Area_Foot(ByVal Area)

        With frm_Floor_Area

            'Disable Foot Text Box
            .txt_Foot.Enabled = False

            'Convert Foot to other units.
            dec_Centimetres = Area * 929.03
            dec_Inches = Area * 144
            dec_Metres = Area * 0.092903
            dec_Yards = Area * 0.111111

            'Output
            .txt_Centimetres.Text = dec_Centimetres.ToString
            .txt_Inches.Text = dec_Inches.ToString
            .txt_Metres.Text = dec_Metres.ToString
            .txt_Yards.Text = dec_Yards.ToString

        End With

    End Sub

    Public Sub Floor_Area_Inches(ByVal Area)

        With frm_Floor_Area

            'Disable Inches Text Box
            .txt_Inches.Enabled = False

            'Convert Inches to other units.
            dec_Centimetres = Area * 6.4516
            dec_Foot = Area * 0.00694444
            dec_Metres = Area * 0.00064516
            dec_Yards = Area * 0.000771605

            'Output
            .txt_Centimetres.Text = dec_Centimetres.ToString
            .txt_Foot.Text = dec_Foot.ToString
            .txt_Metres.Text = dec_Metres.ToString
            .txt_Yards.Text = dec_Yards.ToString

        End With

    End Sub

    Public Sub Floor_Area_Metres(ByVal Area)

        With frm_Floor_Area

            'Disable Metres Text Box
            .txt_Metres.Enabled = False

            'Convert Metres to other units.
            dec_Centimetres = Area * 10000
            dec_Foot = Area * 10.7639
            dec_Inches = Area * 1550
            dec_Yards = Area * 1.19599

            'Output
            .txt_Centimetres.Text = dec_Centimetres.ToString
            .txt_Foot.Text = dec_Foot.ToString
            .txt_Inches.Text = dec_Inches.ToString
            .txt_Yards.Text = dec_Yards.ToString

        End With

    End Sub

    Public Sub Floor_Area_Yards(ByVal Area)

        With frm_Floor_Area

            'Disable Yards Text Box
            .txt_Yards.Enabled = False

            'Convert Yards to other units.
            dec_Centimetres = Area * 8361.27
            dec_Foot = Area * 9
            dec_Inches = Area * 1296
            dec_Metres = Area * 0.836127

            'Output
            .txt_Centimetres.Text = dec_Centimetres.ToString
            .txt_Foot.Text = dec_Foot.ToString
            .txt_Inches.Text = dec_Inches.ToString
            .txt_Metres.Text = dec_Metres.ToString

        End With

    End Sub


End Module
