Public Class FruitsForm



    ' Declare an array to hold fruits

    Dim fruits() As String = {"Apple", "Banana", "Cherry"}



    Private Sub DisplayButton_Click(sender As Object, e As EventArgs) Handles DisplayButton.Click

        ' TODO: Display the fruits in the FruitsListBox

    End Sub



    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click

        ' TODO: Get the fruit name from InputFruitTextBox and add it to the fruits array

        ' Ensure to resize the array to accommodate the new fruit

        ' Clear the InputFruitTextBox after adding the fruit

    End Sub



    Private Sub RemoveButton_Click(sender As Object, e As EventArgs) Handles RemoveButton.Click

        ' TODO: Remove the last fruit from the fruits array

        ' Ensure to resize the array to reflect the removed fruit

    End Sub



End Class
