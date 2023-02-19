'Program Name: AirBnb
'Developer: Maria Jackson
'Date: Feb 19, 2023
'Purpose: This program takes user input for number of nights to stay at an AirBnb
'         The total cost for the num nights given is caluclated and displayed
'         User may clear their input and start over or exit the program at any time

Option Strict On
Public Class frmAirBnB
    ' declare const price per night value - used in form load and btnCost events
    Const cdecPricePerNight As Decimal = 79D 'constant 79.00 as cost of one night
    Private Sub frmAirBnB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' sets lblCostHeading text to contain actual price value
        ' sets lblTotalCost text to blank string
        ' initiates focus to txtNumberOfNights
        txtNumberOfNights.Focus()
        lblTotalCost.Text = ""
        lblCostHeading.Text = "Only " + cdecPricePerNight.ToString("C2") + " per Night!"

    End Sub

    Private Sub btnCost_Click(sender As Object, e As EventArgs) Handles btnCost.Click
        ' uses txtnumberOfNights input to calculate & display total cost of AirBnB stay
        ' declares string and int versions of numberOfNights variable
        ' declares total cost of stay as decimal variable
        ' converts number of nights to integer from string
        ' calculates total cost of stay as numNights * cost of night

        Dim strNumberOfNights As String 'num nights from txt input
        Dim intNumberOfNights As Integer 'num nights as int, holds converted value
        Dim decTotalCostOfStay As Decimal 'total cost as decimal

        'get input from txtNumberOfNights
        strNumberOfNights = txtNumberOfNights.Text
        'Convet input to int
        Try
            intNumberOfNights = Convert.ToInt32(strNumberOfNights)
            'Calculate total cost
            decTotalCostOfStay = intNumberOfNights * cdecPricePerNight
            'Convert total cost to String for display
            lblTotalCost.Text = decTotalCostOfStay.ToString("C2")
        Catch badFormat As FormatException
            txtNumberOfNights.Clear()
            txtNumberOfNights.Focus()
        End Try

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clears txtNumberOfNights input, resets lblTotalCost text
        ' Sets focus onto txtNumberOfNights
        txtNumberOfNights.Clear()
        txtNumberOfNights.Focus()
        lblTotalCost.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' closes window & exits the program
        Close()
    End Sub
End Class
