Module Room_Volume_Conversions

#Region "Module Variables"

    'Declare Module Variables
    Dim dec_Centimetres As Decimal
    Dim dec_Foot As Decimal
    Dim dec_Inches As Decimal
    Dim dec_Metres As Decimal
    Dim dec_Yards As Decimal

#End Region

    'ByVal Volume creates a variable so that a copy of the area value can be sent to the sub.

    Public Sub Room_Volume_Centimetres(ByVal Volume)

        With frm_Room_Volume

            'Disable Centimetres Text Box
            .txt_Centimetres.Enabled = False

            'Convert Centimeters to other units.
            dec_Foot = Volume * 0.00107639
            dec_Inches = Volume * 0.155
            dec_Metres = Volume * 0.0001
            dec_Yards = Volume * 0.000119599

            'Output
            .txt_Foot.Text = dec_Foot.ToString
            .txt_Inches.Text = dec_Inches.ToString
            .txt_Metres.Text = dec_Metres.ToString
            .txt_Yards.Text = dec_Yards.ToString

        End With

    End Sub

    Public Sub Room_Volume_Foot(ByVal Volume)

        With frm_Room_Volume

            'Disable Foot Text Box
            .txt_Foot.Enabled = False

            'Convert Foot to other units.
            dec_Centimetres = Volume * 929.03
            dec_Inches = Volume * 144
            dec_Metres = Volume * 0.092903
            dec_Yards = Volume * 0.111111

            'Output
            .txt_Centimetres.Text = dec_Centimetres.ToString
            .txt_Inches.Text = dec_Inches.ToString
            .txt_Metres.Text = dec_Metres.ToString
            .txt_Yards.Text = dec_Yards.ToString

        End With

    End Sub

    Public Sub Room_Volume_Inches(ByVal Volume)

        With frm_Room_Volume

            'Disable Inches Text Box
            .txt_Inches.Enabled = False

            'Convert Inches to other units.
            dec_Centimetres = Volume * 6.4516
            dec_Foot = Volume * 0.00694444
            dec_Metres = Volume * 0.00064516
            dec_Yards = Volume * 0.000771605

            'Output
            .txt_Centimetres.Text = dec_Centimetres.ToString
            .txt_Foot.Text = dec_Foot.ToString
            .txt_Metres.Text = dec_Metres.ToString
            .txt_Yards.Text = dec_Yards.ToString

        End With

    End Sub

    Public Sub Room_Volume_Metres(ByVal Volume)

        With frm_Room_Volume

            'Disable Metres Text Box
            .txt_Metres.Enabled = False

            'Convert Metres to other units.
            dec_Centimetres = Volume * 10000
            dec_Foot = Volume * 10.7639
            dec_Inches = Volume * 1550
            dec_Yards = Volume * 1.19599

            'Output
            .txt_Centimetres.Text = dec_Centimetres.ToString
            .txt_Foot.Text = dec_Foot.ToString
            .txt_Inches.Text = dec_Inches.ToString
            .txt_Yards.Text = dec_Yards.ToString

        End With

    End Sub

    Public Sub Room_Volume_Yards(ByVal Volume)

        With frm_Room_Volume

            'Disable Yards Text Box
            .txt_Yards.Enabled = False

            'Convert Yards to other units.
            dec_Centimetres = Volume * 8361.27
            dec_Foot = Volume * 9
            dec_Inches = Volume * 1296
            dec_Metres = Volume * 0.836127

            'Output
            .txt_Centimetres.Text = dec_Centimetres.ToString
            .txt_Foot.Text = dec_Foot.ToString
            .txt_Inches.Text = dec_Inches.ToString
            .txt_Metres.Text = dec_Metres.ToString

        End With

    End Sub


End Module
