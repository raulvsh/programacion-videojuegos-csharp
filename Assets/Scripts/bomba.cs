using UnityEngine;

public class bomba : MonoBehaviour
{
    public int tiempoCuenta = 0;
    private float segundoActual = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        segundoActual += Time.deltaTime;
        if(segundoActual >= 1)
        {
            tiempoCuenta--;
            print("Tic: " + tiempoCuenta);
            segundoActual = 0;

            if (tiempoCuenta <= 0)
            {
                explotar();
                //Destroy(this);
                Destroy(gameObject);
            }
        }


    }

    void explotar()
    {
        print("Boooooom!!!");
    }
}
