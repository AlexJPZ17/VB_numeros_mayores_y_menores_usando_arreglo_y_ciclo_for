Module Module1
    Public Sub MenorMayor()
        'Declaramos las variables
        Dim num, numero, menor, mayor, suma As Integer
        Dim promedio As Double

        Console.WriteLine("Introduzca la cantidad de posiciones  ")
        num = Convert.ToInt32(Console.ReadLine())
        'Declaramos un arreglo 
        Dim arreglo(num) As Integer
        'Introducir los números utilizando un ciclo for
        For i = 1 To num
            'Mostramos un mensaje y capturamos el valor ingresado
            Console.WriteLine("Introduzca un numero" & (i))
            numero = Convert.ToInt32(Console.ReadLine())
            arreglo(i) = numero
        Next
        'Buscamos el menor y el mayor
        menor = arreglo(1)
        mayor = arreglo(1)
        'Ciclo for
        For x = 1 To num
            'Condición que evalúa la variable menor y arreglo
            If menor > arreglo(x) Then
                menor = arreglo(x)
            End If
            If mayor < arreglo(x) Then
                mayor = arreglo(x)
            End If

        Next
        suma = 0
        'Claculamos el promedio
        'Ciclo for
        For y = 1 To num
            suma = suma + arreglo(y)
        Next
        promedio = suma / arreglo.Length
        'Mostramos los resultados 
        Console.WriteLine("En nuero menor es : " & menor)
        Console.WriteLine("En nuero mayor es : " & mayor)
        Console.WriteLine("El promedio de los números es : " & promedio)
        Console.ReadLine()
    End Sub
    Sub Main()
        'Llamamos al método MenorMayor
        MenorMayor()
    End Sub

End Module
