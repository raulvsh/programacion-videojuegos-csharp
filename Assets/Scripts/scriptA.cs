using UnityEngine;

public class scriptA : MonoBehaviour
{
    [SerializeField]
    int numero1 = 0; //variable privada

    public int numero2 = 0; //variable p�blica

    public static int numero3 = 25; //variable p�blica est�tica

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        numero1 = 12;
        print(numero1);
    }

    public static string funcionEstatica()
    {
        //print("Funci�n est�tica");
        return ("Funcion est�tica");
    }

    public string funcionPublica()
    {
        //print("Funci�n p�blica");
        return ("Funcion p�blica");

    }


}
