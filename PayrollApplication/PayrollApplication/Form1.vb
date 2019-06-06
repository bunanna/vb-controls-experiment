'************
' By Brianna Barrow

'************

Public Class Form1


    Dim sngTotalGrossPay, sngTotalFicaTax, sngTotalWithheldTax As Single
    Dim sngGrossPay, sngFicaTax, sngWithheldTax As Single

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Const sngSSN_TAX = 0.062
        Const sngMEDICARE_TAX = 0.0145
        Const sngWITHHELD_TAX_LIMIT = 84000
        Dim sngHourlyWage, sngHoursWorked, sngNewYearEarnings, sngYearEarnings As Single
        Dim sngAdjustedGross, sngNetPay, sngMedicareTax, sngSocialSecurity As Single
        Dim bytExemptions As Byte
        Dim strName As String
        Dim blnGrossPayConfirm, blnWithheldTaxConfirm, blnMaritalStatusConfirm, blnExemptionsConfirm, blnYearToDateEarningsConfirm As Boolean

        '**************************************************
        'Gross Pay Calculation
        'Status: Working
        Try
            sngHourlyWage = Single.Parse(txtHourlyWage.Text, Globalization.NumberStyles.Currency)
        Catch ex As Exception
            lblStatus.Text = "Please confirm that the entered wage is a numerical value."
        End Try

        If Single.TryParse(txtHoursWorked.Text, sngHoursWorked) Then
            If sngHourlyWage > 0 And sngHoursWorked > 0 Then
                If sngHoursWorked <= 40 Then
                    sngGrossPay = sngHoursWorked * sngHourlyWage
                ElseIf sngHoursWorked > 40 Then
                    sngGrossPay = ((sngHoursWorked - 40) * (sngHourlyWage * 1.5)) + (sngHourlyWage * 40)
                End If
                blnGrossPayConfirm = True
            End If
        Else
            blnGrossPayConfirm = False
        End If

        '**************************************************
        'Withheld Tax Calculation
        'Status: Working
        If Short.TryParse(txtExemptions.Text, bytExemptions) Then
            If bytExemptions >= 0 And bytExemptions <= 10 Then
                If radMarried.Checked = True Or radSingle.Checked = True Then
                    sngAdjustedGross = sngGrossPay - (55.77 * bytExemptions)
                    Select Case sngAdjustedGross
                        Case Is < 501
                            If radSingle.Checked = True Then
                                sngWithheldTax = (sngAdjustedGross - 51) * 0.1
                            ElseIf radMarried.Checked = True Then
                                sngWithheldTax = (sngAdjustedGross - 51) * 0.05
                            End If
                        Case Is < 2501
                            If radSingle.Checked = True Then
                                sngWithheldTax = ((sngAdjustedGross - 501) * 0.15) + 45
                            ElseIf radMarried.Checked = True Then
                                sngWithheldTax = ((sngAdjustedGross - 501) * 0.1) + 22.5
                            End If
                        Case Is < 5001
                            If radSingle.Checked = True Then
                                sngWithheldTax = ((sngAdjustedGross - 2501) * 0.2) + 345
                            ElseIf radMarried.Checked = True Then
                                sngWithheldTax = ((sngAdjustedGross - 2501) * 0.15) + 225.5
                            End If
                        Case Is >= 5001
                            If radSingle.Checked = True Then
                                sngWithheldTax = ((sngAdjustedGross - 5001) * 0.25) + 845
                            ElseIf radMarried.Checked = True Then
                                sngWithheldTax = ((sngAdjustedGross - 5001) * 0.2) + 600.5
                            End If
                        Case Else
                            sngWithheldTax = 0
                    End Select
                    blnExemptionsConfirm = True
                    blnMaritalStatusConfirm = True
                Else
                    blnExemptionsConfirm = True
                    blnMaritalStatusConfirm = False
                End If
            Else
                blnExemptionsConfirm = False
                blnMaritalStatusConfirm = False
            End If
        Else
            blnExemptionsConfirm = False
            blnMaritalStatusConfirm = False
        End If

        '**************************************************
        'Withheld Tax Confirmation
        'Status: Working

        If blnExemptionsConfirm = True And blnMaritalStatusConfirm = True Then
            blnWithheldTaxConfirm = True
        Else
            blnWithheldTaxConfirm = False
        End If

        '**************************************************
        'Fica Tax, Updated Year Earnings, and Net Pay Calculations
        'Status: Working

        Try
            sngYearEarnings = Single.Parse(txtYearToDateEarnings.Text, Globalization.NumberStyles.Currency)
        Catch ex As Exception
            lblStatus.Text = "Please confirm that the entered year-to-date earnings are numerical values."
        End Try

        If sngYearEarnings > 0 Then
            sngMedicareTax = sngGrossPay * sngMEDICARE_TAX
            If (sngGrossPay + sngYearEarnings) < sngWITHHELD_TAX_LIMIT Then
                sngSocialSecurity = sngGrossPay * sngSSN_TAX
            ElseIf sngYearEarnings > sngWITHHELD_TAX_LIMIT Then
                sngSocialSecurity = 0
            Else
                sngSocialSecurity = (sngWITHHELD_TAX_LIMIT - sngYearEarnings) * sngSSN_TAX
            End If
            blnYearToDateEarningsConfirm = True
        Else
            blnYearToDateEarningsConfirm = False
        End If

        sngFicaTax = sngSocialSecurity + sngMedicareTax

        sngNetPay = sngGrossPay - sngFicaTax - sngWithheldTax

        sngNewYearEarnings = sngYearEarnings + sngGrossPay

        '**************************************************
        'Check for Completion and Error Message Handling
        'Status: Working
        If txtName.Text <> String.Empty Then
            If blnGrossPayConfirm = True Then
                If blnWithheldTaxConfirm = True Then
                    If blnYearToDateEarningsConfirm = True And txtYearToDateEarnings.Text <> String.Empty Then

                        strName = txtName.Text

                        lblName.Text = strName

                        lblGrossEarnings.Text = sngGrossPay.ToString("c")

                        lblFicaTax.Text = sngFicaTax.ToString("c")

                        lblFedTax.Text = sngWithheldTax.ToString("c")

                        lblNetPay.Text = sngNetPay.ToString("c")

                        lblUpdatedEarnings.Text = sngNewYearEarnings.ToString("c")

                        lblStatus.Text = String.Empty
                        txtName.BackColor = Color.White
                        txtExemptions.BackColor = Color.White
                        txtYearToDateEarnings.BackColor = Color.White
                        txtHourlyWage.BackColor = Color.White
                        txtHoursWorked.BackColor = Color.White
                        radMarried.BackColor = Color.WhiteSmoke
                        radSingle.BackColor = Color.WhiteSmoke
                    Else
                        lblStatus.Text = "Please confirm that your year-to-date earnings have been entered correctly."
                        sngGrossPay = 0
                        sngFicaTax = 0
                        sngWithheldTax = 0
                        txtName.BackColor = Color.White
                        txtExemptions.BackColor = Color.White
                        txtYearToDateEarnings.BackColor = Color.Yellow
                        txtHourlyWage.BackColor = Color.White
                        txtHoursWorked.BackColor = Color.White
                        radMarried.BackColor = Color.WhiteSmoke
                        radSingle.BackColor = Color.WhiteSmoke
                        txtYearToDateEarnings.Focus()
                    End If
                ElseIf blnMaritalStatusConfirm = False And blnExemptionsConfirm = True Then
                    lblStatus.Text = "Please confirm that your marital status has been selected."
                    sngGrossPay = 0
                    sngFicaTax = 0
                    sngWithheldTax = 0
                    txtName.BackColor = Color.White
                    txtExemptions.BackColor = Color.White
                    txtYearToDateEarnings.BackColor = Color.White
                    txtHourlyWage.BackColor = Color.White
                    txtHoursWorked.BackColor = Color.White
                    radMarried.BackColor = Color.Yellow
                    radSingle.BackColor = Color.Yellow
                Else
                    lblStatus.Text = "Please confirm that marital status and exemptions have been entered correctly."
                    sngGrossPay = 0
                    sngFicaTax = 0
                    sngWithheldTax = 0
                    txtName.BackColor = Color.White
                    txtExemptions.BackColor = Color.Yellow
                    txtYearToDateEarnings.BackColor = Color.White
                    txtHourlyWage.BackColor = Color.White
                    txtHoursWorked.BackColor = Color.White
                    radMarried.BackColor = Color.Yellow
                    radSingle.BackColor = Color.Yellow
                    txtExemptions.Focus()
                End If
            Else
                sngGrossPay = 0
                sngFicaTax = 0
                sngWithheldTax = 0
                lblStatus.Text = "Please confirm that the wage and hours worked are correct."
                txtName.BackColor = Color.White
                txtExemptions.BackColor = Color.White
                txtYearToDateEarnings.BackColor = Color.White
                txtHourlyWage.BackColor = Color.Yellow
                txtHoursWorked.BackColor = Color.Yellow
                radMarried.BackColor = Color.WhiteSmoke
                radSingle.BackColor = Color.WhiteSmoke
                txtHourlyWage.Focus()
            End If
        Else
            lblStatus.Text = "Please enter your name to begin."
            txtName.BackColor = Color.Yellow
        End If

        '**************************************************
        'Accumulated Pay
        'Status: Working
        sngTotalGrossPay += sngGrossPay

        sngTotalFicaTax += sngFicaTax

        sngTotalWithheldTax += sngWithheldTax

        '**************************************************

    End Sub

    Private Sub btnSummary_Click(sender As Object, e As EventArgs) Handles btnSummary.Click

        '**************************************************
        'Accumulated Pay Display
        'Status: Working

        lblTotalGrossPay.Text = sngTotalGrossPay.ToString("c")

        lblTotalWithheldTax.Text = sngTotalWithheldTax.ToString("c")

        lblTotalFicaTax.Text = sngTotalFicaTax.ToString("c")

        '**************************************************

    End Sub

    Private Sub btnNextEmployee_Click(sender As Object, e As EventArgs) Handles btnNextEmployee.Click

        '**************************************************
        'Entry Clearing
        'Status: Working

        txtName.Clear()
        txtHourlyWage.Clear()
        txtHoursWorked.Clear()
        txtYearToDateEarnings.Clear()
        txtExemptions.Clear()

        lblName.Text = String.Empty
        lblGrossEarnings.Text = String.Empty
        lblFedTax.Text = String.Empty
        lblFicaTax.Text = String.Empty
        lblNetPay.Text = String.Empty
        lblUpdatedEarnings.Text = String.Empty

        radMarried.Checked = False
        radSingle.Checked = False

        txtName.BackColor = Color.White
        txtExemptions.BackColor = Color.White
        txtYearToDateEarnings.BackColor = Color.White
        txtHourlyWage.BackColor = Color.White
        txtHoursWorked.BackColor = Color.White
        radMarried.BackColor = Color.WhiteSmoke
        radSingle.BackColor = Color.WhiteSmoke

        txtName.Focus()
        '**************************************************

    End Sub

    Private Sub btnHideSummary_Click(sender As Object, e As EventArgs) Handles btnHideSummary.Click
        '**************************************************
        'Hiding Payroll Summary
        'Status: Working

        lblTotalFicaTax.Text = String.Empty
        lblTotalGrossPay.Text = String.Empty
        lblTotalWithheldTax.Text = String.Empty
        '**************************************************

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        '**************************************************
        'Resetting entries and accumulated payroll
        'Status: Working

        sngGrossPay = 0
        sngFicaTax = 0
        sngWithheldTax = 0
        sngTotalFicaTax = 0
        sngTotalWithheldTax = 0
        sngTotalGrossPay = 0

        txtName.Clear()
        txtHourlyWage.Clear()
        txtHoursWorked.Clear()
        txtYearToDateEarnings.Clear()
        txtExemptions.Clear()

        lblName.Text = String.Empty
        lblGrossEarnings.Text = String.Empty
        lblFedTax.Text = String.Empty
        lblFicaTax.Text = String.Empty
        lblNetPay.Text = String.Empty
        lblUpdatedEarnings.Text = String.Empty

        radMarried.Checked = False
        radSingle.Checked = False

        txtName.BackColor = Color.White
        txtExemptions.BackColor = Color.White
        txtYearToDateEarnings.BackColor = Color.White
        txtHourlyWage.BackColor = Color.White
        txtHoursWorked.BackColor = Color.White
        radMarried.BackColor = Color.WhiteSmoke
        radSingle.BackColor = Color.WhiteSmoke

        txtName.Focus()
        '**************************************************

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class
