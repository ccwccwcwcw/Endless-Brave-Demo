using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionP : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
