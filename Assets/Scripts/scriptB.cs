using UnityEngine;

public class scriptB : MonoBehaviour
{
    public scriptA script1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        script1 = gameObject.GetComponent<scriptA>();
        print("Número 2: " + script1.numero2);
        print("Número 3: (static) " + scriptA.numero3);
        print("Función estática: " + scriptA.funcionEstatica());
        print("Función pública: " + script1.funcionPublica());
    }

    

    // Update is called once per frame
    void Update()
    {
        
    }
}
