using UnityEngine;

public class StringArray : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public string datosCadena = "Nombre:Lucrecia*Edad:54*Saldo:450€*Tlf:555123123";
    float saldo = 0;
    void Start()
    {
        /*for (int i = 0; i < datosCadena.Length; i++)
        {
         print(datosCadena[i]);
        }
        */
        print ("Desde función Start(): " + encuentraCadena(datosCadena));


    }

    float encuentraCadena(string cadenaBusqueda)
    {
        string saldoRecuperado = string.Empty;
        string campoBusqueda = "Saldo:";
        int indiceSaldo = 0;
        if (cadenaBusqueda.Contains(campoBusqueda))
        {
            indiceSaldo = cadenaBusqueda.IndexOf(campoBusqueda) + campoBusqueda.Length;
            print("Si contiene saldo");
            for(int i = indiceSaldo; i< cadenaBusqueda.Length; i++)
            {
                if (cadenaBusqueda[i] == '*')
                {
                    break;
                }

                saldoRecuperado += cadenaBusqueda[i];
            }

            saldoRecuperado = saldoRecuperado.Replace("€", "");

            print("Desde función encuentraCadena(), string: " + saldoRecuperado);

            saldo = float.Parse(saldoRecuperado);
            print("Desde función encuentraCadena(), float: " + saldo);
            return saldo;
        }
        else
        {
            print("No contiene saldo");
            return 0;
        }
    }

    
}
