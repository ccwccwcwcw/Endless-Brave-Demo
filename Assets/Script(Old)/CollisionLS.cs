using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionLS : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            ScoreManager.instance.Add3Point();
        }
    }
}
