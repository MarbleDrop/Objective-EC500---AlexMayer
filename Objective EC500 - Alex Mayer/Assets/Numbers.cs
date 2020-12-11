using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Numbers : MonoBehaviour
{
    public int rand;

    public bool Solution1 = false;
    public bool Solution2 = false;
    public bool Solution3 = false;
    public bool Solution4 = false;
    public bool Solution5 = false;

    public string Code1Temp = "";
    public static bool Temp = false;
    public string Code2Food = "";
    public static bool Food = false;

    private void Start()
    {
        // Generates random number to chose one of 5 random solutions.
        rand = Random.Range(1, 6);

        // Choosese one of 5 solutions
        if (rand == 1)
        {
            Solution1 = true;
        }
        else if (rand == 2)
        {
            Solution2 = true;
        }
        else if (rand == 3)
        {
            Solution3 = true;
        }
        else if (rand == 4)
        {
            Solution4 = true;
        }
        else if (rand == 5)
        {
            Solution5 = true;
        }

        // Provided solutions.
        if (Solution1 == true)
        {
            Code1Temp = "32";
            Code2Food = "17";
        }
        else if (Solution2 == true)
        {
            Code1Temp = "29";
            Code2Food = "48";
        }
        else if (Solution3 == true)
        {
            Code1Temp = "45";
            Code2Food = "16";
        }
        else if (Solution4 == true)
        {
            Code1Temp = "38";
            Code2Food = "24";
        }
        else if (Solution5 == true)
        {
            Code1Temp = "12";
            Code2Food = "34";
        }
    }
}
