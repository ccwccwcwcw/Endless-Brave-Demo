using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Body : MonoBehaviour
{
    public EnemyHealth enemyHealth;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Glover")
        {
            enemyHealth.TakeDamage(2);
        }
        if (other.gameObject.tag == "ball")
        {
            enemyHealth.TakeDamage(5);

        }
    }
}
