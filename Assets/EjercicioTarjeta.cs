using System;
using System.Collections;
using System.Timers;
using UnityEngine;

public class EjercicioTarjeta : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public string password = "123456";
    public string pin = "";
    public bool acceptButton = false;
    int numericPin = 0;
    void Start()
    {
        MostrarMensajeBienvenida();
    }

    private void Update()
    {
        CheckPin();
        acceptButton = false;
    }

    private void CheckPin()
    {
        if (!acceptButton)
        {
            return;
        }
        if (!IsPinValid())
        {
            return;
        }
        if (pin == password)
        {
            print("La clave es correcta:");
            print("Pin introducido: " + pin);
            print("Clave: " + password);
        }
        else
        {
            print("La clave no es correcta.");
        }
    }

    private bool IsPinValid()
    {
        acceptButton = false;

        if (pin.Length != password.Length)
        {
            print("La longitud debe ser de " + password.Length + " dígitos.");
            return false;
        }
        if (!int.TryParse(pin, out numericPin))
        {
            print("El pin debe ser numérico");
            return false; 
        }
        return true;
    }

    private void MostrarMensajeBienvenida()
    {
        print("Introduzca un número PIN");
        print("Los requisitos son:");
        print("- Debe ser numérico.");
        print("- Debe tener " + password.Length + " cifras.");
    }
}
