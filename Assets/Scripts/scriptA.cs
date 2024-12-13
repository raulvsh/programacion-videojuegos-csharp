using UnityEngine;

public class scriptA : MonoBehaviour
{
    [SerializeField]
    int numero1 = 0; //variable privada

    public int numero2 = 0; //variable pública

    public static int numero3 = 25; //variable pública estática

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        numero1 = 12;
        print(numero1);
    }

    public static string funcionEstatica()
    {
        //print("Función estática");
        return ("Funcion estática");
    }

    public string funcionPublica()
    {
        //print("Función pública");
        return ("Funcion pública");

    }


}
