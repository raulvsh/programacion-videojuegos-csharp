using UnityEngine;

public class scriptB : MonoBehaviour
{
    public scriptA script1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        script1 = gameObject.GetComponent<scriptA>();
        print("N�mero 2: " + script1.numero2);
        print("N�mero 3: (static) " + scriptA.numero3);
        print("Funci�n est�tica: " + scriptA.funcionEstatica());
        print("Funci�n p�blica: " + script1.funcionPublica());
    }

    

    // Update is called once per frame
    void Update()
    {
        
    }
}
