
// punto 1 taller
//Sebastian Rojas Gomez

Console.WriteLine("ingrese los valores del primer semestrales del año");
double valor1 = double.Parse(Console.ReadLine());
Console.WriteLine("ingrese los valores del segundo semestrales del año");
double valor2 = double.Parse(Console.ReadLine());

if ((valor1+valor2)<10000){
    Console.WriteLine("El total de su renta anual es: $"+(valor1+valor2));
    Console.WriteLine("El total de renta apagar es: $"+ (valor1+valor2)*1.05);
    Console.WriteLine("El impuesto aplicado es 5%" );
    Environment.Exit(0);
} 
if ((valor1+valor2)>=10000&&(valor1+valor2)<20000){
    Console.WriteLine("El total de su renta anual es: $"+(valor1+valor2));
    Console.WriteLine("El total de renta apagar es: $"+ (valor1+valor2)*1.1);
    Console.WriteLine("El impuesto aplicado es 10%" );
    Environment.Exit(0);
} 
if ((valor1+valor2)>=20000&&(valor1+valor2)<35000){
    Console.WriteLine("El total de su renta anual es: $"+(valor1+valor2));
    Console.WriteLine("El total de renta apagar es: $"+ (valor1+valor2)*1.15);
    Console.WriteLine("El impuesto aplicado es 15%" );
    Environment.Exit(0);
} 
if ((valor1+valor2)>=35000&&(valor1+valor2)<45000){
    Console.WriteLine("El total de su renta anual es: $"+(valor1+valor2));
    Console.WriteLine("El total de renta apagar es: $"+ (valor1+valor2)*1.2);
    Console.WriteLine("El impuesto aplicado es 20%" );
    Environment.Exit(0);
} 
if ((valor1+valor2)>=45000){
    Console.WriteLine("El total de su renta anual es: $"+(valor1+valor2));
    Console.WriteLine("El total de renta apagar es: $"+ (valor1+valor2)*1.3);
    Console.WriteLine("El impuesto aplicado es 30%" );
    Environment.Exit(0);
} 

