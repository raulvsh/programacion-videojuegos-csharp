using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using Unity.Collections;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class variablesFunciones : MonoBehaviour
{
    // Start is called before the first frame update

    /*
        bool: Almacena un valor l�gico(true o false). Tiene un tama�o de 1 bit.

        byte: Almacena un n�mero entero sin signo entre 0 y 255. Tiene un tama�o de 8 bits.

        sbyte: Almacena un n�mero entero con signo entre -128 y 127. Tiene un tama�o de 8 bits.

        short: Almacena un n�mero entero con signo entre -32,768 y 32,767. Tiene un tama�o de 16 bits.

        ushort: Almacena un n�mero entero sin signo entre 0 y 65,535. Tiene un tama�o de 16 bits.

        int: Almacena un n�mero entero con signo entre -2,147,483,648 y 2,147,483,647. Tiene un tama�o de 32 bits.

        uint: Almacena un n�mero entero sin signo entre 0 y 4,294,967,295. Tiene un tama�o de 32 bits.

        long: Almacena un n�mero entero con signo entre -9,223,372,036,854,775,808 y 9,223,372,036,854,775,807. Tiene un tama�o de 64 bits.

        ulong: Almacena un n�mero entero sin signo entre 0 y 18,446,744,073,709,551,615. Tiene un tama�o de 64 bits.

        char: Almacena un car�cter Unicode.Tiene un tama�o de 16 bits (2 bytes).

        float: Almacena un n�mero real con precisi�n simple.Tiene un tama�o de 32 bits.

        double: Almacena un n�mero real con precisi�n doble.Tiene un tama�o de 64 bits.

        decimal: Almacena un n�mero decimal con precisi�n fija.Tiene un tama�o de 128 bits.
    */

    // String tama�o variable
    public int numeroPublico = 13;


    [SerializeField]
    private int numeroEntero = 0;
    float numeroDecimal = 0.0f;

    byte numeroCorto = 0;
    bool booleano = false;
    char caracter = 'r';
    string cadena = "palabras o frases";

    string cadena2 = "123 Adc";


    void Start()
    {


    }



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            imprimeHola();
        }

    }


    void imprimeHola()
    {
        Debug.Log("Espacio pulsado");
    }
}