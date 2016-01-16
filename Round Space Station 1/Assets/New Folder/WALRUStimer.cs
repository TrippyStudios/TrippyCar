using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class WALRUStimer : MonoBehaviour
{
    int currenttime = 0;
    public int time;
    // Use this for initialization
    void Update()
    {
        if (currenttime < time)
        {
            currenttime += 1;
        }
        if (Input.GetButtonDown("WALRUS"))
        {
            SceneManager.LoadScene("SECRET");
        }
        else
        {
            Application.Quit();
            SceneManager.LoadScene(0);
        }
    }
}
