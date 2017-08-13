Module StudentDataBase

    Dim maxIloscOcen As Integer = 9 'maksymalna ilosc (tzn ilosc +1, czyli jak masz podane 9 to ilosc = 10) ocen jakie obiekt klasy student moze posiadac

    Public Class Student 'klasa student

        Dim imie, nazwisko As String 'deklaracja imienia i nazwiska jako string

        Dim indeks As Integer 'deklaracja numeru indeksu studenta jako int

        Public Oceny(maxIloscOcen) As Double 'deklaracja publicznej zmiennej tablicowej oceny typu double

        Sub New(imie As String, nazwisko As String, indeks As String) 'kostruktor obiektu klasy przyjmujacy imie, nazwisko i numer indeksu

            Me.imie = imie 'wartosc podana przy wywolaniu konstruktora zapisana jako imie przypisz do pola klasy o nazwie imie
            Me.nazwisko = nazwisko 'Me.nazwisko <- pole klasy; nazwisko <- zmienna w konstruktorze
            Me.indeks = indeks

        End Sub

        Public Function Oblicz_srednia() As Double 'funkcja publiczna liczaca srednia

            Dim sumaOcen As Double = 0

            Dim iloscOcen As Integer = 0

            For i = 0 To maxIloscOcen 'przelec kazdy wpis w tablicy

                If Oceny(i) <> 0 Then 'dla kazdego i sprawdz czy oceny(i) != 0 i jesli nie (0 jest wtedy gdy ocena nie zostala wpisana)

                    sumaOcen += Oceny(i) 'to dodaj ta ocene do sumy ocen 
                    iloscOcen += 1 'i powieksz ilosc ocen o 1

                End If

            Next

            If iloscOcen <> 0 Then 'jesli student posiada wiecej niz zero ocen

                Return sumaOcen / iloscOcen 'podziel sume ocen przez ich ilosc i zwroc jako wartosc sredniej

            Else 'jesli student posiada zero ocen

                Console.WriteLine("Student nie posiada zadnej oceny!") 'wypisz blad ze student nie posiada zadnej oceny
                Return 0 ' i zwroc 0 jako srednia

            End If

        End Function

    End Class

    Sub Main() 'glowna funkcja programu

        Dim ja As Student = New Student("Emb", "Rion", 6662137) 'utworz obiekt klasy student o nazwie ja

        ja.Oceny(0) = 2.0 'na pozycje 0 wpisz ocene
        ja.Oceny(1) = 2.0
        ja.Oceny(2) = 2.0

        Console.WriteLine("Średnia: " + ja.Oblicz_srednia().ToString()) 'wypisz stringa "Srednia: " i wartosc sredniej studenta ja zamienionej na stringa

        Console.ReadKey() 'czekaj na wcisniecie jakiegokowliek klawisza, aby okno konsoli nie zostalo zamkniete

    End Sub

End Module
