''' <summary>
''' Victoria Valdron 100548556
''' NET DEVELOPMENT LAB 1
''' 2019-01-25
''' In this lab we have to create an application that takes in the input for 7 days, and calculate the average of all 7 inputs.
''' </summary>



Public Class FrmAverageShipped
    'Variables'
    Dim dayNumber As Integer = 1
    Const TOTAL_DAYS As Integer = 7
    Dim ifInteger As Integer
    Dim day(6) As Integer
    Dim average As Integer
    Const MAX_NUM As Integer = 1000
    Const MIN_NUM As Integer = 0

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        'ends the application'
        Application.Exit()


    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        TxtInput.Clear()
        TxtDisplay.Clear()
        dayNumber = 1
        LblDay.Text = "Day" & dayNumber


    End Sub

    Private Sub BtnEnter_Click(sender As Object, e As EventArgs) Handles BtnEnter.Click
        'input validation'

        If Integer.TryParse(TxtInput.Text, ifInteger) Then
            ' Testing to see if the input is an integer '
            If (ifInteger >= MIN_NUM And ifInteger <= MAX_NUM) Then





                'excecute if above condition is true'
                If (dayNumber < TOTAL_DAYS) Then

                    'putting inputs into the array'
                    day(dayNumber - 1) = ifInteger



                    'Allow number of days to increase with each hit of the enter button'
                    dayNumber += 1

                    'Takes input of the txtInput and displays it into the txDisplay'
                    TxtDisplay.AppendText(ifInteger & Environment.NewLine)


                    'For 7th day, I created an else if so that once I press enter for the 7th day, it will automatically calculate the average in the bottom box'
                ElseIf (dayNumber = TOTAL_DAYS) Then


                    day(dayNumber - 1) = ifInteger

                    TxtDisplay.AppendText(ifInteger & Environment.NewLine)

                    'Calculating the average of the inputs'
                    average = day.Sum / day.Count

                    'Display average to the output label'
                    LblOutput.Text = average

                End If

                LblDay.Text = "Day" & dayNumber

                If (dayNumber > TOTAL_DAYS) Then

                    LblDay.Text = "Day" & dayNumber - 1

                End If
                ' If the input is above 1000 or below 0 it will be considered out of range '
            Else MessageBox.Show("Input out of range, please try again.")
            End If

            ' If the input is not an integer value, it will be an error '
        Else MessageBox.Show("Input is not an integer, please try again.")

        End If






    End Sub


End Class
