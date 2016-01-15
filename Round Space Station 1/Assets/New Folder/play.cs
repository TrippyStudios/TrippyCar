using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class play : MonoBehaviour {

	// Use this for initialization
	public void changeScene () {
        SceneManager.LoadScene(2);
	}
}
