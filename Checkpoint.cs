using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
//    [SerializeField] private Transform player;
    [SerializeField] private Transform checkPoint;
    
    private void OnTriggerEnter(Collider other)
    {
        //player = GameObject.FindGameObjectWithTag("Player").transform;
        //checkPoint = GameObject.FindGameObjectWithTag("Respawn").transform;
        if(other.tag == "Respawn")
            PlayerRespawn.LastCheckPointPos = other.transform.position;
        
         
    }

   
}
   
    //Vector2 positionInfo;
    /*private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            PlayerRespawn.LastCheckPointPos = transform.position;
        }
    }*/
    /*void OnCollisionEnter(Collision other)
    {
        if (obj.gameObject.name == "Player")
            PlayerRespawn.LastCheckPointPos = transform.position;
    }
}*/
    