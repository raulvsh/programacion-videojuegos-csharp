using Unity.VisualScripting;
using UnityEngine;
using System.Collections.Generic;
using System.Collections;


public class ArrayList : MonoBehaviour


{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    List<object> listaArray = new List<object>();
    void Start()
    {

        listaArray.Add("Uno");
        listaArray.Add(12);
        listaArray.Add("Tres");
        listaArray.Add("Cuatro");
        listaArray.Add(1.2f);
        listaArray.Add("Seis");

        print("El tamaño de la lista es " + listaArray.Count);
        foreach (object obj in listaArray)
        {
            print(obj);
        }

        if (listaArray.Contains("Uno"))
        {
            print("Contiene el Uno");
        }
        //print(listaArray);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
