using UnityEngine;
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
    }
}
