Module Module1

    Sub Main()
        'declaration
        Dim I As Integer
        Dim novowels As Integer
        Dim vowels As String
        Dim word As String
        'initialization
        I = 0
        novowels = 0
        vowels = ""
        word = ""
        'data inputing
        Console.WriteLine("Enter a word")
        word = Console.ReadLine
        'data processing
        vowels = "aeiou"
        For I = 1 To Len(word)
            If InStr(vowels, Mid(word, I, 1)) Then
                novowels = novowels + 1
            End If
        Next I
        Console.WriteLine("No of vowels in the word= " & novowels)
        Console.ReadKey()




    End Sub

End Module
