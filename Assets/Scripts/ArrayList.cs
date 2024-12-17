using Unity.VisualScripting;
using UnityEngine;
using System.Collections.Generic;
using System.Collections;


public class ArrayList : MonoBehaviour


{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    List<object> objectList = new List<object>();


    void Start()
    {

        //Objetos añadidos a List<object>
        objectList.Add("Uno");
        objectList.Add(12);
        objectList.Add("Tres");
        objectList.Add("Cuatro");
        objectList.Add(1.2f);
        objectList.Add("Seis");

        print("El tamaño de la lista es " + objectList.Count);
        foreach (object obj in objectList)
        {
            print(obj);
        }

        if (objectList.Contains("Uno"))
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
