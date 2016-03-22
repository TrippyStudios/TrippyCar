using UnityEngine;
using System.Collections;

public class AICarTouches : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Score_Cube")
        {
            Destroy(col.gameObject);
        }
        else if (col.gameObject.name == "DEATH")
        {
            Destroy(col.gameObject);
        }
    }
    // Update is called once per frame
        void Update () {
	
	}
}
