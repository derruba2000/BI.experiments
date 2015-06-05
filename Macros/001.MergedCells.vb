Sub FindMerged2()
Dim c As Range
For Each c In ActiveSheet.UsedRange
If c.MergeCells Then
c.Interior.ColorIndex = 36
End If
Next
End Sub
