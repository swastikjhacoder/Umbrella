Public Class Urdu

    Public Shared Function ToUrdu(ByVal english_str As String) As String

        Dim urdu_str As String = Nothing

        For i As Integer = 0 To english_str.Length - 1
            If Char.IsWhiteSpace(english_str(i)) Or Char.IsDigit(english_str(i)) Then
                urdu_str += english_str(i)
            Else
                urdu_str += ConvertToUrdu(english_str(i))
            End If
        Next

        Return urdu_str

    End Function

    Public Shared Function ConvertToUrdu(ByVal inp As Char) As Char

        ''Small Letter Conversion 
        If (inp = "a") Then
            Return ChrW(&H627) ''converting a into ALIF

        ElseIf (inp = "b") Then
            Return ChrW(&H628) ''converting b into Bay

        ElseIf (inp = "c") Then
            Return ChrW(&H686) ''converting c into Chay

        ElseIf (inp = "d") Then
            Return ChrW(&H62F) ''converting d into DALL

        ElseIf (inp = "e") Then
            Return ChrW(&H639)  ''converting e into AIN

        ElseIf (inp = "f") Then
            Return ChrW(&H641) ''converting f into FAY 

        ElseIf (inp = "g") Then
            Return ChrW(&H6AF) ''converting g into Gaaf

        ElseIf (inp = "h") Then
            Return ChrW(&H6BE) ''converting h into Haa

        ElseIf (inp = "i") Then
            Return ChrW(&H6CC) ''converting i into choti YA

        ElseIf (inp = "j") Then
            Return ChrW(&H62C) ''converting j into Geem

        ElseIf (inp = "k") Then
            Return ChrW(&H6A9) ''converting k into Kiaf

        ElseIf (inp = "l") Then
            Return ChrW(&H644) ''converting l into Laam

        ElseIf (inp = "m") Then
            Return ChrW(&H645) ''converting m into meem

        ElseIf (inp = "n") Then
            Return ChrW(&H646) ''converting n into noon

        ElseIf (inp = "o") Then
            Return ChrW(&H6C1) ''converting o into hay

        ElseIf (inp = "p") Then
            Return ChrW(&H67E) ''converting p into paay

        ElseIf (inp = "q") Then
            Return ChrW(&H642) ''converting q into kaaf

        ElseIf (inp = "r") Then
            Return ChrW(&H631) ''converting r into Ray

        ElseIf (inp = "s") Then
            Return ChrW(&H633) ''converting s into Ceen

        ElseIf (inp = "t") Then
            Return ChrW(&H62A) ''converting t into tay

        ElseIf (inp = "u") Then
            Return ChrW(&H621) ''converting u into Hamza

        ElseIf (inp = "v") Then
            Return ChrW(&H637) ''converting v into Toain

        ElseIf (inp = "w") Then
            Return ChrW(&H648) ''converting w into waoo

        ElseIf (inp = "x") Then
            Return ChrW(&H634) ''converting x into Sheem

        ElseIf (inp = "y") Then
            Return ChrW(&H6D2) ''converting y into Bari ya

        ElseIf (inp = "z") Then
            Return ChrW(&H632) ''converting z into Zay

            'Capital Letter Conversion

        ElseIf (inp = "A") Then
            Return ChrW(&H622) ''converting A into ALI MAD AA

        ElseIf (inp = "B") Then
            Return ChrW(&H613) ''converting B into RAZI

        ElseIf (inp = "C") Then
            Return ChrW(&H62B) ''converting C into SAAY

        ElseIf (inp = "D") Then
            Return ChrW(&H688) ''converting D into DAAL

        ElseIf (inp = "E") Then
            Return ChrW(&H611) ''converting E into ALIHE

        ElseIf (inp = "F") Then
            Return ChrW(&H641) ''converting F into FAY

        ElseIf (inp = "G") Then
            Return ChrW(&H63A) ''converting G into GHAIN

        ElseIf (inp = "H") Then
            Return ChrW(&H62D) ''converting H into HAY

        ElseIf (inp = "I") Then
            Return ChrW(&H6CC) ''converting I into Laam

        ElseIf (inp = "J") Then
            Return ChrW(&H636) ''converting J into ZOOAD

        ElseIf (inp = "K") Then
            Return ChrW(&H62E) ''converting K into HAY

        ElseIf (inp = "L") Then
            Return ChrW(&H612) ''converting l into Laam

        ElseIf (inp = "M") Then
            Return ChrW(&H645) ''converting M into MEEM

        ElseIf (inp = "N") Then
            Return ChrW(&H6BA) ''converting N into GHUNNA

        ElseIf (inp = "O") Then
            Return ChrW(&H629) ''converting O into TAYH

        ElseIf (inp = "P") Then
            Return ChrW(&H64F) ''converting P into PAISH

        ElseIf (inp = "Q") Then
            Return ChrW(&H648) ''converting Q into WAOO

        ElseIf (inp = "R") Then
            Return ChrW(&H691) ''converting R into RRAY

        ElseIf (inp = "S") Then
            Return ChrW(&H635) ''converting S into SOOAD

        ElseIf (inp = "T") Then
            Return ChrW(&H679) ''converting T into TAAY

        ElseIf (inp = "U") Then
            Return ChrW(&HFEFB) ''converting U into LaaMLA

        ElseIf (inp = "V") Then
            Return ChrW(&H638) ''converting V into XOOAIN

        ElseIf (inp = "W") Then
            Return ChrW(&H648) ''converting W into WAOO

        ElseIf (inp = "X") Then
            Return ChrW(&H632) ''converting X into ZAY

        ElseIf (inp = "Y") Then
            Return ChrW(&H6D2) ''converting Y into BARI YA

        ElseIf (inp = "Z") Then
            Return ChrW(&H630) ''converting Z into ZAAL

        End If

        Return Nothing

    End Function

End Class