using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.name =="Player")
        {
            Destroy(other.gameObject);
        }
            
       
    }
}
