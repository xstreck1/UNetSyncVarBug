using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Bullet : NetworkBehaviour {

    [SyncVar]
    public string myPlayer = "myPlayer";

	// Use this for initialization
	void Start () {

        Debug.Log("player name is set to\"" + myPlayer + "\".");
    }
}
