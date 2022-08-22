// Punto 3. 
Console.WriteLine("Digite el tipo de pizza que desea:"+"\n"+"1.Vegetariana"+"\n"+"2.No vegetariana");
uint Pizza = uint.Parse((Console.ReadLine()));

if (Pizza==1){
    Console.WriteLine("Los ingredientes disponibles son:"+"\n"+"1.Pimientos"+"\n"+"2.Champiñones");
    uint Ingrediente = uint.Parse((Console.ReadLine()));
    if (Ingrediente==1){
        Console.WriteLine("Su pizza es vegetariana"+"\n"+"Tiene pimientos, mozzarella y tomate");
         Environment.Exit(0);
    }
    if (Ingrediente==2){
        Console.WriteLine("Su pizza es vegetariana"+"\n"+"Tiene champiñones, mozzarella y tomate");
         Environment.Exit(0);
    }
    Console.WriteLine("Opcion incorrecta");
    Environment.Exit(0);
}
if (Pizza==2){
    Console.WriteLine("Los ingredientes disponibles son:"+"\n"+"1.Pepperoni"+"\n"+"2.Salami"+"\n"+"3.Pollo");
    uint Ingrediente = uint.Parse((Console.ReadLine()));
    if (Ingrediente==1){
        Console.WriteLine("Su pizza no es vegetariana"+"\n"+"Tiene pepperoni, mozzarella y tomate");
         Environment.Exit(0);
    }
    if (Ingrediente==2){
        Console.WriteLine("Su pizza no es vegetariana"+"\n"+"Tiene salami, mozzarella y tomate");
         Environment.Exit(0);
    }
    if (Ingrediente==3){
        Console.WriteLine("Su pizza no es vegetariana"+"\n"+"Tiene pollo, mozzarella y tomate");
         Environment.Exit(0);
    }
    Console.WriteLine("Opcion incorrecta");
    Environment.Exit(0);
}
Console.WriteLine("Pizza no existente");
