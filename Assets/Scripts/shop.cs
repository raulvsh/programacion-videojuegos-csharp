using UnityEngine;

public class shop : MonoBehaviour
{

    float oroPrecio = 1000;
    float plataPrecio = 500;
    float broncePrecio = 100;

    public float saldo = 2000;
    float carrito = 0;

    public bool realizarCompra = false;

    public bool seleccionOro = false;
    public bool seleccionPlata = false;
    public bool seleccionBronce = false;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //print("Bienvenido a la tienda, seleccione y compre sus articulos.");
    }

    /*private void Awake()
    {
        print("Awake");
    }

    private void LateUpdate()
    {

        print("LateUpdate");
    }

    private void FixedUpdate()
    {

    }*/

    // Update is called once per frame
    void Update()
    {
        if (realizarCompra)
        {
            carrito = 0;
            if (seleccionOro)
            {
                carrito += oroPrecio;
            }
            if (seleccionPlata)
            {
                carrito += plataPrecio;
            }
            if (seleccionBronce)
            {
                carrito += broncePrecio;
            }

            if (saldo >= carrito && carrito > 0)
            {
                saldo -= carrito;
                print("Compra realizada, su saldo actual es de: " + saldo + "€");

            }
            else
            {
                if(carrito <= 0)
                {
                    print("No se ha podido realizar la compra, seleccione un artículo.");
                    print("El importe del carrito es: " + carrito + "€");
                }
                else
                {
                    print("No se ha podido realizar la compra, su saldo es: " + saldo + "€");
                    print("El importe del carrito es: " + carrito + "€");
                }



            }


            realizarCompra =false;

        }
    }
}
