using UnityEngine;
using UnityEngine.UIElements;


public class EjercicioPoker : MonoBehaviour
{
    private char[] diceValues = { '7', '8', 'J', 'Q', 'K', 'A' };
    private char[] diceArray = new char[6];

    public bool throwDices = false;
    public int throws = 0;
    public bool[] dicesSelection = new bool[6];
    public bool reset;



    private void Start()
    {
        initializeGame();

    }

    private void initializeGame()
    {
        throws = 1;
        throwDices = false;
        dicesSelection = new bool[] { true, true, true, true, true, true };
        reset = false;
        print("Realice su tirada:");
    }

    // Update is called once per frame
    private void Update()
    {
        if (reset)
        {
            initializeGame();

        }
        if (throwDices)
        {
            for (int i = 0; i < diceArray.Length; i++)
            {
                if (dicesSelection[i])
                    diceArray[i] = diceValues[Random.Range(0, 6)];
                //print(diceArray[i]);
            }
            print("Tirada " + throws + ": " + string.Join(", ", diceArray));

            throws++;
            throwDices = false;
        }
    }
}