using UnityEngine;
using System.Collections;

public class carPulse : MonoBehaviour {
    float xscale;
	// Use this for initialization
	void Start () {
        xscale = 1;
	}
	
	// Update is called once per frame
	void Update () {
            if (xscale < 3)
            {
                xscale += .1F;
                transform.localScale = new Vector3(xscale, 2, 1);
            }
            if (xscale > 1)
            {
                xscale -= .1F;
                transform.localScale = new Vector3(xscale, 2, 1);
            }
	}
}
