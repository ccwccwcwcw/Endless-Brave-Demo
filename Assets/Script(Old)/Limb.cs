using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Limb : MonoBehaviour
{
    
   public void Hit()
    {
        transform.localScale = Vector3.zero;
    }

    // Update is called once per frame
   private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Weapon"))
            Hit();
    }
}
