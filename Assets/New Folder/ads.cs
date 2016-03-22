using UnityEngine;
using System.Collections;
using UnityEngine.Advertisements; // Declare the Unity Ads namespace.

public class ads : MonoBehaviour
{
    // Define gameId as a public field
    //  so it can be set from the Inspector.
    public string gameId;

    void Start()
    {
        if (Advertisement.isSupported)
        { // If the platform is supported,
            Advertisement.Initialize(gameId); // initialize Unity Ads.
        }
    }
}