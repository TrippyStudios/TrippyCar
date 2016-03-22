using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
public class TouchedScriptPointsmain : MonoBehaviour
{

    Text txt;
    int CSS = 0;
    int level;
    void Start()
    {
        CSS = 0;
        string score = CSS.ToString();
        print("Initialized ZERO");
        txt = gameObject.GetComponent<Text>();
        txt.text = "Time: " + score;
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Score_Cube")
        {
            Destroy(col.gameObject);
        }
        else if (col.gameObject.name == "DEATH")
        {
            print("TUUS MORTUS ES");
            SceneManager.LoadScene("DEATH");
        }
        else if (col.gameObject.name == "youWin")
        {
            SceneManager.LoadScene(level+10);
        }

    }
    void Update()
    {
        if (GameObject.Find("lvl1"))
        {
            level = 1;
        }
        else if (GameObject.Find("lvl2"))
        {
            level = 2;
        }
        else if (GameObject.Find("lvl3"))
        {
            level = 3;
        }
        else if (GameObject.Find("lvl4"))
        {
            level = 4;
        }
        else if (GameObject.Find("lvl5"))
        {
            level = 5;
        }
        else if (GameObject.Find("lvl6"))
        {
            level = 6;
        }
        else if (GameObject.Find("lvl7"))
        {
            level = 7;
        }
        else if (GameObject.Find("lvl8"))
        {
            level = 8;
        }
        if (Input.GetButtonDown("Cancel"))
        {
            Application.Quit();
            print("QUIT");
        }
        string score = CSS.ToString();
        txt.text = "Time: " + score;
       // print("Loaded");
       // print(score);
        if (AICarFinished.AIDone)
        {
            print("TUUS MORTUS ES");
            SceneManager.LoadScene("DEATH");
        }
    }
}