using UnityEngine;

public class arrays3 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    int[,] matriz = new int[4,4]; //filas y columnas
    string filaActual = "";
    void Start()
    {
        int contador = 0;
        for(int i = 0; i < matriz.GetLength(0); i++) //coge el tamaño de la posición 0 de la matriz, en este caso 2
        {
            filaActual = "";
            for(int j = 0; j < matriz.GetLength(1); j++) //coge el tamaño de la posición 0 de la matriz, en este caso 3
            {
                contador++;
                matriz[i,j] = contador;
                filaActual += contador.ToString() + ", ";
            }
            print(filaActual);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
