using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Secret : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    
    public void continuer()
    {
        Destroy(GameObject.Find("Canvas"));
        SceneManager.LoadScene(0)
    }
}
