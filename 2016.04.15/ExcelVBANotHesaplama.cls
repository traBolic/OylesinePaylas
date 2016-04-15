Private Sub Worksheet_SelectionChange(ByVal Target As Range)
Dim i As Byte
Range("A1:I20").ClearContents
Randomize
For i = 1 To 20
Cells(i, 1) = Int((101 * Rnd))

Cells(i, 2) = Int((101 * Rnd))

Cells(i, 3) = (Cells(i, 1) + Cells(i, 2)) / 2

Cells(i, 4) = Application.StDev(Range("A" + CStr(i) + ":B" + CStr(i)))

Cells(i, 5) = 0.4 * Cells(i, 1)
Cells(i, 6) = 0.6 * Cells(i, 2)

Cells(i, 7) = Cells(i, 5) + Cells(i, 6)

Cells(i, 8) = Application.StDev(Range("E" + CStr(i) + ":F" + CStr(i)))

OPlusS = Cells(i, 7) + Cells(i, 8)
Cells(i, 9) = IIf(OPlusS >= 90, "AA", _
                    IIf(OPlusS >= 80, "BA", _
                    IIf(OPlusS >= 70, "BB", _
                    IIf(OPlusS >= 65, "CB", _
                    IIf(OPlusS >= 60, "CC", _
                    IIf(OPlusS >= 55, "DC", _
                    IIf(OPlusS >= 50, "DD", _
                                      "FF"  _
                                      )))))))
Next
End Sub
