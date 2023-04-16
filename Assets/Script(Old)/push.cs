using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class push : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Glover")
        {
            this.GetComponent<Rigidbody> ().AddForce(Vector3.left*100.0f);
        }
    }
}
