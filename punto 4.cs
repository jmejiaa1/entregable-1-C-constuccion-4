//Punto 4
Console.WriteLine("Ingrese el nombre del empleado");
String Nombre = Console.ReadLine();
Console.WriteLine("Elija el valor de valoracion"+"\n"+"1)0.0"+"\n"+"2)0.4"+"\n"+"3)0.6");
float Valoracion = float.Parse(Console.ReadLine());

if (Valoracion==1){
    Console.WriteLine("La valoracion del empleado es inaceptable (0.0) y su bonificacion es: 0");
    Environment.Exit(0);
}
if (Valoracion==2){
    Console.WriteLine("La valoracion del empleado es aceptable (0.4) y su bonificacion es: "+(50000*0.4));
    Environment.Exit(0);
}
if (Valoracion==3){
    Console.WriteLine("La valoracion del empleado es meritorio (0.6) y su bonificacion es: "+(50000*0.6));
    Environment.Exit(0);
}
Console.WriteLine("El numero de validacion no es posible realizarla");


