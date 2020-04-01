using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movementScript;

    void OnCollisionEnter(Collision collisionInfo) 
    {
        if(collisionInfo.collider.tag == "obstacle")
        {
            movementScript.enabled = false;
            FindObjectOfType<ManagerScript>().EndGame();
        }
    }
}
