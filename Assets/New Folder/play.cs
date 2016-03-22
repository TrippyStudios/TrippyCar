using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class play : MonoBehaviour {

	// Use this for initialization
    void Update()
    {
        if(Input.GetButtonDown("Submit"))
        {
            changeScene("lvlselect");
        }
    }
	public void changeScene (string level) {
        SceneManager.LoadScene(level);
	}
}
