using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    public float minY = -10f;
    public Transform respawnPoint;

    private void Update()
    {
        if (transform.position.y < minY)
        {
            RespawnPlayer();
        }

        void RespawnPlayer()
        {

            transform.position = respawnPoint.position;
            transform.rotation = respawnPoint.rotation;
        }
    }
}
