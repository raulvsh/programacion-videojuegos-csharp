using UnityEngine;

public class LeerManager : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameManager gameManager;

    void Start()
    {
        gameManager.puntos = 1000;
        print("La puntuaci�n extra�da de gameManager es: " + gameManager.puntos);

        print("El resultado de la funci�n suma es: " + gameManager.sumaPuntos(100));
    }

}
