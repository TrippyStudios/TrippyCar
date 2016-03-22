using UnityEngine;
using System.Collections;

public class godMode : MonoBehaviour {
    public static bool godModeActive;
    public GameObject godMenu;
	// Use this for initialization
	void Start () {
        godMenu.SetActive(false);
        if (godModeActive == true)
        {
            godMenu.SetActive(true);
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
