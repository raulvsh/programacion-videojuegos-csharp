using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int puntos = 1000;

    private void Start()
    {
        puntos = 1000;
    }

    public int sumaPuntos(int puntuacion)
    {
        puntos += puntuacion;
        return puntos;
    }
    
}
