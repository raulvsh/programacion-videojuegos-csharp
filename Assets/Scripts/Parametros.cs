using UnityEngine;

public class Parametros : MonoBehaviour
{
    public float width = 10;
    public float height = 20;

    float area;
    float perimetro;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        area = calculaAreaRectangulo(width, height);
        perimetro = calculaPerimetroRectangulo(width, height);
        //print("El �rea del rect�ngulo es: " + area);
        //print("El per�metro del rect�ngulo es: " + perimetro);


    }

    float calculaAreaRectangulo(float width, float height)
    {
        float area = width * height;
        return area;
    }

    float calculaPerimetroRectangulo(float width, float height)
    {
        perimetro = 2 * (width + height);
        return perimetro;
    }

}
