using UnityEngine;
using System.Collections;

public class InitModes : MonoBehaviour
{
    public static bool godModeActive;
 
    public void checkCode(string code)
    {
        if (code == "AlphaWebDunTripped")
        {

        }
        if (code == "revelation13:18")
        {
            godModeActive = true;
        }
    }
}

[System.Serializable]
public class SaveModes
{

    public static void GodMode()
    {
        
    }
}
