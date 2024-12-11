using System.Collections.Generic;
using UnityEngine;

public class bucleFor : MonoBehaviour
{
    public int numeroFibonacci;

   

    List<int> fibonacciList = new List<int>();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        calculaSerieFibonacciFor(numeroFibonacci);
        calculaSerieFibonacciWhile(numeroFibonacci);

    }

    void calculaSerieFibonacciWhile(int numeroFibonacci)
    {

        int x1 = 0;
        int x2 = 1;
        int numActual = 0;
        string serieCompletaFibonacci = "";

        int i = 0;

        serieCompletaFibonacci += x1;
        serieCompletaFibonacci += ", ";

        serieCompletaFibonacci += x2;

        fibonacciList.Add(x1);
        fibonacciList.Add(x2);

        while (i < numeroFibonacci - 2)
        {
            serieCompletaFibonacci += ", ";
            serieCompletaFibonacci += (x1 + x2).ToString();

            numActual = x2;
            x2 = x1 + x2;
            x1 = numActual;

            i++;
        }

        Debug.Log("Funcion con while: " + serieCompletaFibonacci);

    }

    void calculaSerieFibonacciFor(int numeroFibonacci)
    {
        int x1 = 0;
        int x2 = 1;
        int numActual = 0;

        fibonacciList.Add(x1);
        fibonacciList.Add(x2);

        //Debug.Log("x1: " + x1);
        //Debug.Log("x2: " + x2);


        for (int i = 0; i < numeroFibonacci-2; i++)
        {
            //x2 = x1 + x2;
            //Debug.Log("Paso: " + i);

            //Debug.Log("x1: " + x1);
            //Debug.Log("x2: " + x2);
            //Debug.Log("c: " + (x1 + x2));
            fibonacciList.Add(x1 + x2);

            numActual = x2;
            x2 = x1 + x2;
            x1 = numActual;

        }
        Debug.Log("Bucle for: " + string.Join(", ", fibonacciList));
    }
}

 
