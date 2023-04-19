using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragon : MonoBehaviour
{
    // Start is called before the first frame update
    public int HP = 100;
    public Animator animator;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "OHSword")
        {
            TakeDamage(10);
            Debug.Log("collision");
        }
    }

    public void TakeDamage(int damageAmount)
    {
        HP -= damageAmount;
        if (HP <= 0)
        {
            animator.SetTrigger("die");
            GetComponent<Collider>().enabled = false;
        }
        else 
        {
            animator.SetTrigger("damage");
        }
    }
}
