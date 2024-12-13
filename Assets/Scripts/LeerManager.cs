using UnityEngine;

public class LeerManager : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameManager gameManager;

    void Start()
    {
        gameManager.puntos = 1000;
        print("La puntuación extraída de gameManager es: " + gameManager.puntos);

        print("El resultado de la función suma es: " + gameManager.sumaPuntos(100));
    }

}
