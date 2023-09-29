Module Module1

    Sub Main()
        'Se solicita el ingreso de la cantidad de esquelas impuestas por el agente
        Console.WriteLine("Ingrese la cantidad de esquelas impuestas este mes: ")
        Dim esquelas As Integer = Console.ReadLine()
        'se verifica que la cantidad de esquelas sea correcta o valida, en caso de no ser asi, mostrara error
        If esquelas > 0 Then
            'calculo de porcentajes de esquelas
            Dim pormañana As Double = esquelas * 0.2
            Dim portarde As Double = esquelas * 0.35
            Dim portnoche As Double = esquelas * 0.45
            'Mostrar el porcentaje de cada una en pantalla
            Console.WriteLine("El porcentaje de esquelas impuestas por la mañana es: " & Math.Round(pormañana, 2))
            Console.WriteLine("El porcentaje de esquelas impuestas por la tarde es: " & Math.Round(portarde, 2))
            Console.WriteLine("El porcentaje de esquelas impuestas por la noche es: " & Math.Round(portnoche, 2))
        Else
            'Muestra error si el dato ingresado es invalido
            Console.WriteLine("Error!... Dato ingresado es invalido")
        End If
        Console.WriteLine("")
        'datos de autor
        Console.WriteLine("Alumno: Francisco Salvador Moreno Garcia     Carnet: MG1250012022")
        Console.ReadLine()

    End Sub

End Module
