Module Module1
    Sub Main()
        Console.WriteLine("_____________________________________________________________")
        Console.WriteLine("Convertir Velocidad  kilómetros por hora a Metros por Segundo  \")
        Console.WriteLine("_____________________________________________________________/")
        Console.WriteLine("Desarrollado por ANGELY GOMEZ, C.I: 23.900.539")
        Console.WriteLine("")
            ' Solicitar al usuario que ingrese la velocidad en km/h
            Console.Write("Por favor, ingresa la velocidad en kilómetros por hora: ")
            Dim velocidadKmH As Double = Double.Parse(Console.ReadLine())

            ' Convertir la velocidad a m/s
            Dim velocidadMS As Double = velocidadKmH * 1000 / 3600

            ' Mostrar la velocidad en m/s
            Console.WriteLine("La velocidad en metros por segundo es: " & velocidadMS & " m/s")
  
        Console.WriteLine("")
        ' Esperar a que el usuario presione una tecla antes de cerrar
        Console.WriteLine("Presiona cualquier tecla para salir.")

        Console.ReadKey()
    End Sub
End Module
