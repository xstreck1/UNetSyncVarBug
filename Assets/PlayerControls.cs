using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class PlayerControls : NetworkBehaviour
{
    public float speed = 2f;
    private NetworkStartPosition[] spawnPoints;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (NetworkManager.singleton.isNetworkActive && !isLocalPlayer)
        {
            return;
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        if (Input.GetKey(KeyCode.Escape))
        {
            NetworkManager.singleton.StopHost();
        }
    }
}
