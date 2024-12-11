using UnityEngine;

public class mayorNumero : MonoBehaviour
{
    public int numero1 = 0;
    public int numero2 = 0;
    public int numero3 = 0;

    int numeroMayor = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (numero1 >= numero2)
        {
            if(numero1 > numero3)
            {
                numeroMayor = numero1;
            }
            else
            {
                numeroMayor = numero3;
            }

        }
        else
        {
            if (numero2 > numero3)
            {
                numeroMayor = numero2;
            }
            else
            {
                numeroMayor = numero3;
            }
        }

        //print("El número mayor es: " + numeroMayor);
    }


}
