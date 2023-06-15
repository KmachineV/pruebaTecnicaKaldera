// See https://aka.ms/new-console-template for more information

using System;
using System.Text.RegularExpressions;



//calculo de area triangulo
static double calculoAreaTriangulo(double baseTriangulo, double altura) => (baseTriangulo * altura) / 2;


Console.WriteLine("Ingresa el valor de la base del triangulo");
double baseTriangulo;

//Valida que el valor ingresado sea solo numerico
while (!double.TryParse(Console.ReadLine(), out baseTriangulo))
{
    Console.Write("Error: Ingrese un valor numerico en la base del triangulo: ");
};

Console.WriteLine("Ingresa el valor de la altura del triangulo");
double alturaTriangulo;

//Valida que el valor ingresado sea solo numerico
while (!double.TryParse(Console.ReadLine(), out alturaTriangulo))
{
    Console.Write("Error: Ingrese un valor numerico en la altura del triangulo: ");
};

var areaTriangulo = calculoAreaTriangulo(baseTriangulo, alturaTriangulo);

Console.WriteLine($"Area triangulo : {areaTriangulo}");


//Retorna la primera palabra que inicie con "A"
static string getFirstStringWithA(string text)
{
    if (text.Contains("{|}"))
    {
        var valueTextReplace = text.Replace("{|}", " ");

        string coincidencia = @"\b[A]\w+";
        Regex rg = new Regex(coincidencia, RegexOptions.IgnoreCase);

        MatchCollection textValueReturn = rg.Matches(valueTextReplace);

        if(textValueReturn != null)
        {
            return textValueReturn[0].Value;
        }
        else
        {
            return "No hay palabras que inicien con 'A'";
        } 

    }

     return "El valor ingresado no contiene '{|}'";    


}
var valueText = getFirstStringWithA("1{|}BA{|}R4{|}A1{|}AE");

Console.WriteLine($"Valor: {valueText}");

//retorna true si es par
static bool  getTrueOnlyPar(int number) => (number % 2) == 0 ? true:false;

var numberPar = getTrueOnlyPar(3);

Console.WriteLine($"¿Es par?: {numberPar}");


//secuencia Fibonacci
int firstValue = 0; int secondValue = 1;

Console.WriteLine(firstValue);

for (var i = 0; i < 40; i++)
{
    var pivot = firstValue;
    firstValue = secondValue;
    secondValue = pivot + firstValue;

    Console.WriteLine(firstValue);
}




