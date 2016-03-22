using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;

public class Secret : MonoBehaviour {

    public GameObject screenOne;
    public GameObject screenTwo;
    // Use this for initialization
	void Start () {
        screenTwo.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    
    public void continuer()
    {
        screenOne.SetActive(false);
        screenTwo.SetActive(true);
    }
    public void player()
    {
        screenTwo.SetActive(false);
    }
}
