using System.Collections.Generic;
using UnityEngine;

public class bucleFor : MonoBehaviour
{
    public int numeroFibonacci;

    int x1 = 0;
    int x2 = 1;

    List<int> fibonacciList = new List<int>();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int c = 0;
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
            fibonacciList.Add(x1+x2);

            c = x2;
            x2 = x1 + x2;
            x1 = c ;

        }
        Debug.Log(string.Join(", ", fibonacciList));

    }
}

 
