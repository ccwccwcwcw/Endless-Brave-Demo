using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sword : MonoBehaviour
{
    public int damageAmount = 10;
    private void Start£¨£©{
        Destroy(gameObject,10);
    }
    private void OnTriggerEnter(Collider other)
    {
    Destroy(transform.GetComponent<Rigibody>());
    if (other.tag == "Dragon") {
        other.GetComponent<Dragon>().TakeDamage(damageAmount);
    }
    }
}
