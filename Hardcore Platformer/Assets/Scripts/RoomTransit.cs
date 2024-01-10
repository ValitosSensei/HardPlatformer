using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomTransit : MonoBehaviour
{
    public Transform player;  
    public Transform camera;  
    public float targetXPositionForCamera = 0f;  
    public float targetXPositionForPlayer = 0f;  

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.gameObject.name == "Player")
        {
            
            MoveCameraToNextLevel();
            MovePlayerToNextLevel();
            Debug.Log("Aktive");
        }
    }

    void MoveCameraToNextLevel()
    {
        
        Vector3 newCameraPosition = new Vector3(targetXPositionForCamera, camera.position.y, camera.position.z);
        camera.position = newCameraPosition;
    }

    void MovePlayerToNextLevel()
    {
        
        Vector3 newPlayerPosition = new Vector3(targetXPositionForPlayer, player.position.y, player.position.z);
        player.position = newPlayerPosition;
    }
}


