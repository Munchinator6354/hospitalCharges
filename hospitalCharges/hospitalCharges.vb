Option Strict On
Option Explicit On
'-----------------------------------------------------------------------------------------
'Program: Hospital Charges
'Programmer: Ryan Isaacson / Munchinator6354 
'Date: November, 04 2020
'Description: 'Calculate a patient's hospital charges
'------------------------------------------------------------------------------------------
Public Class hospitalCharges

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'Declare Variables
        Dim intStayDuration As Integer
        Dim dblMedChg As Double
        Dim dblSurgChg As Double
        Dim dblLabChg As Double
        Dim dblPhysChg As Double
        Dim dblTotalOneDayFees As Double
        Dim dblFinalTotal As Double

        'Call ValidateInputFields Function and pass it the amount of days and various charges
        txtVisitDuration.Focus()
        txtVisitDuration.SelectAll()

        If ValidateInputFields(intStayDuration, dblMedChg, dblSurgChg, dblLabChg, dblPhysChg) = True Then
            'convert # stay days to Integer
            intStayDuration = CInt(txtVisitDuration.Text)
            'convert fees to Double
            dblMedChg = CDbl(txtMedication.Text)
            dblSurgChg = CDbl(txtSurgicalFees.Text)
            dblLabChg = CDbl(txtLabFees.Text)
            dblPhysChg = CDbl(txtPhysical.Text)

            'Calculates total fees per day
            dblTotalOneDayFees = CalcPerDayCharges(dblMedChg, dblSurgChg, dblLabChg, dblPhysChg)

            'Calculates total charges for patient
            dblFinalTotal = CalcFinalBill(intStayDuration, dblTotalOneDayFees)

            'Display toal bill to user
            lblTotalBill.Text = CStr(dblFinalTotal)
        End If
    End Sub

    Function ValidateInputFields(intDayAmt As Integer, dblChg1 As Double, dblChg2 As Double, dblChg3 As Double, dblChg4 As Double) As Boolean
        '-----------------------------------------------------------------------------------------
        'Function: ValidateInputFields
        'Author: Joe Student 
        'Date: January 30, 2017
        'Description: Validate user input fields
        'Return True if all fields valid, False if any fields are invalid
        '------------------------------------------------------------------------------------------
        Dim blnValid As Boolean

        If IsNumeric(intDayAmt) And
            IsNumeric(dblChg1) And
            IsNumeric(dblChg2) And
            IsNumeric(dblChg3) And
            IsNumeric(dblChg4) Then
            blnValid = True
        Else
            MsgBox("All of your inputs must be numbers")
        End If
        'set focus
        'set select all
        Return blnValid

    End Function

    Function CalcPerDayCharges(dblChg1 As Double, dblChg2 As Double, dblChg3 As Double, dblChg4 As Double) As Double
        '-----------------------------------------------------------------------------------------
        'Function: CalcCharges
        'Author: Ryan Isaacson / Munchinator6354
        'Date: November 04 2020
        'Description: 'Calculate miscellaneous charges
        'Return the charges
        '------------------------------------------------------------------------------------------
        Dim dblTotalDayCharges As Double
        dblTotalDayCharges = dblChg1 + dblChg2 + dblChg3 + dblChg4
        Return dblTotalDayCharges
    End Function

    Function CalcFinalBill(dblStay As Double, dblPerDayFeeTotal As Double) As Double
        'Function to Determines final bill total by multiplying total days in hospital by per day charges
        Dim dblFinalBill As Double
        dblFinalBill = dblStay * dblPerDayFeeTotal
        Return dblFinalBill
    End Function

    Private Sub btnClearForm_Click(sender As Object, e As EventArgs) Handles btnClearForm.Click
        txtVisitDuration.Text = "0"
        txtLabFees.Text = "0.00"
        txtMedication.Text = "0.00"
        txtPhysical.Text = "0.00"
        txtSurgicalFees.Text = "0.00"
        txtVisitDuration.Focus()
        txtVisitDuration.SelectAll()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
