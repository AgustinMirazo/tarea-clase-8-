
Console.WriteLine("ingrese cantidad de filas");

int cantidadfila = int.Parse(Console.ReadLine());

Console.WriteLine("ingrese cantidad de columnas");
int cantidadcolumna = int.Parse(Console.ReadLine());


int[,] numeros = new int[cantidadfila, cantidadcolumna];

//vector promedios

//double[] promedios; 



// i = filas  y J = columnas
int i;
int j; 
//ingreso a una fila y lleno todas sus columnas 
for (i =0; i< cantidadfila; i++)
{ Console.WriteLine($"Por favor, para la fila: {i + 1}"); ;

    for (j = 0; j < cantidadcolumna; j++)
    { Console.WriteLine($"ingrese el valor de la columna: {j + 1}");
        numeros [i,j]=int.Parse(Console.ReadLine()); 
    }

}

//muestro los valores ingresados en la matriz 

Console.WriteLine("=====================================");


for (i = 0; i < cantidadfila; i++)
{
    Console.WriteLine($"datos ingresados para la fila: {i + 1}"); 

    for (j = 0; j < cantidadcolumna; j++)
    {
        Console.WriteLine($"valor de la columna: {j + 1}");
        Console.WriteLine(numeros[i,j]);
    }

}
Console.WriteLine("===========================================");


// sumo los valores de la columna para luego poder promediarlos, OJO hay que armar un for anidado porque tiene dos dimensiones

double[] promedios = new double[cantidadcolumna];

double sumacolumnas= 0;

for (j = 0; j < cantidadcolumna; j++)

{
    sumacolumnas = 0;    

    for (i = 0; i < cantidadfila; i++)
    {
        
        sumacolumnas += numeros[i,j];

    }
    promedios[j] = sumacolumnas / i; 

}
// ahora mostrar los valores de los promedios reccorriendo el vector promedio 

for (int promedio = 0; promedio < promedios.Length; promedio++)
{
    Console.Write($"{ Math.Round(promedios[promedio], 2)} {(promedio + 1 < promedios.Length ? ",\t" : " ") }");
    
}

