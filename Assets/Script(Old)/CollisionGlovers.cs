using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionGlovers : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Head")
        {
            print("Hithead!!");
        }
        if (other.gameObject.tag == "Body")
        {
            print("HitBody!!");
        }
    }
    
    
}
 