using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public Transform player;
    public int index;

    private void Awake()
    {
        player = GameObject.Find("Player").transform;
        if(DataConteiner.checkpointIndex == index)
        {
            player.position = transform.position;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.name == "Player")
        {
            if(index> DataConteiner.checkpointIndex)
            {
                DataConteiner.checkpointIndex = index;
            }
            
        }
    }
}
