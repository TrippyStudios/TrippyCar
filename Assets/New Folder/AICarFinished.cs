using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class AICarFinished : MonoBehaviour {
    public static bool AIDone;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "youWin")
        {
            AIDone = true;
            SceneManager.LoadScene("DEATH");
        }
    }
}
