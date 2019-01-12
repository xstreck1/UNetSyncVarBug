using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class Shoot : NetworkBehaviour
{
    public GameObject bullet;

    void Update()
    {
        if (isLocalPlayer)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                CmdShoot();
            }
        }
    }

    [Command]
    public void CmdShoot()
    {
        GameObject newBullet = Instantiate(bullet, transform.position, transform.rotation, null) as GameObject;
        newBullet.GetComponent<Bullet>().myPlayer = "test";
        AddVel(newBullet);
        NetworkServer.Spawn(newBullet);
    }

    void AddVel(GameObject newBullet)
    {
        newBullet.GetComponent<Rigidbody>().velocity = Vector3.right * 5f;
    }
}
