using UnityEngine;

public class LeerNameSpace : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        print(NameSpace1.Variables.puntuacion);

        int valor = 2;
        print("El cuadrado de " + valor + " es: " + NameSpace1.Metodos.cuadrado(valor));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
