using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Head : MonoBehaviour
{
    public EnemyHealth enemyHealth;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Glover")
        {
            enemyHealth.TakeDamage(5);
        }
        if (other.gameObject.tag == "ball")
        {
            enemyHealth.TakeDamage(10);

        }
    }
}
