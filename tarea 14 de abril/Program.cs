

    void Promedio()
    {
       
        Console.WriteLine("Ingrese su Nombre:");
        string nom = Console.ReadLine();

        Console.WriteLine("Ingrese su Nota:");
        double not1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese su Nota:");
        double not2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese su Nota:");
        double not3 = double.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese su Nota:");
       double not4 = double.Parse(Console.ReadLine());
    
    double promedio = (not1 + not2 + not3 + not4) / 4;
       

        Console.WriteLine("" + nom);
        Console.WriteLine("El promedio de su notas es: " + promedio);

        
    }
Promedio();


