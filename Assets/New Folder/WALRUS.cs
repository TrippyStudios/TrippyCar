using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class WALRUS : MonoBehaviour
{
    void Update()
    {
        if (Input.GetButtonDown("WALRUS"))
        {
            changeScene();
        }
    }
    // Use this for initialization
    public void changeScene()
    {
        SceneManager.LoadScene("WALRUS");
    }
}
