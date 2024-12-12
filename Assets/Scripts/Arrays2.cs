using UnityEditor;
using UnityEngine;

public class arrays2 : MonoBehaviour
{

    int[] array1 = { 1,2,3,4,5};

    string cadenaArrayFor = "";
    string cadenaArrayForEach = "";


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < array1.Length; i++)
        {
            //print(array1[i]);
            cadenaArrayFor += array1[i] + ", ";
        }
        foreach(int valor in array1)
        {
            //print(entero);
            cadenaArrayFor += valor + ", ";

        }

        print("Cadena array for: " + cadenaArrayFor);
        print("Cadena array forEach: " + cadenaArrayForEach);

    }

}
