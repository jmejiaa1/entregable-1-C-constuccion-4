// Escribir un programa para una sala de juegos que quiere calcular de forma automática el 
// precio que debe cobrar a sus clientes por ingresar. El software solicita al usuario el nombre 
// completo y la edad del cliente para que  muestra al final el nombre completo, el precio de la 
// entrada y su descuento si lo tiene. Si el cliente es menor de 4 años puede entrar gratis, si tiene 
// entre 4 y 18 años debe pagar la entrada y tendrá un descuento del 5% y si es mayor de 18 años debe 
// pagar la entrada y tendrá un descuento del 3%. La entrada tiene un valor de 15000$.


int entrada=15000;
Console.WriteLine("ingrese su nombre");
string nombre=Console.ReadLine();
Console.WriteLine("ingrese su edad");
int edad=int.Parse(Console.ReadLine());
int descuento;

if (edad<4 && edad>0){

    Console.WriteLine("el ususario: "+nombre+ " con la edadd de: "+edad+" no debe pagar la endtrada");

}else if(edad>=4 && edad<18){
    descuento=(entrada*5)/100;
    entrada=entrada-descuento;
    Console.WriteLine("el ususario: "+nombre+ " con la edad de: "+edad+ " debe pagar un valor de: $"+ entrada+" ya que tiene un descuento  de: $"+descuento+" por su edad");
}else if (edad>18){
descuento=(entrada*3)/100;
    entrada=entrada-descuento;
    Console.WriteLine("el ususario: "+nombre+ " con la edad de: "+edad+ " debe pagar un valor de: $"+ entrada+" ya que tiene un descuento  de: $"+descuento+" por su edad"); 
}else{
     Console.WriteLine("su edad es incorecta");
    
}

//juan diego mejia 
 
  