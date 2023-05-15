using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dragon : MonoBehaviour
{
    // Start is called before the first frame update
    private int HP = 100;
    public Animator animator;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "OHSword")
        {
            TakeDamage(10);
            Debug.Log("collision");
        }
        if (other.tag == "OHAxe")
        {
            TakeDamage(15);
            Debug.Log("collision");
        }
        if (other.tag == "OHHammer")
        {
            TakeDamage(13);
            Debug.Log("collision");
        }
        if (other.tag == "OHMace")
        {
            TakeDamage(14);
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
            Destroy(gameObject,3.0f);
            AudioManager.instance.Play("DragonDeath");
        }
        else 
        {
            animator.SetTrigger("damage");
            AudioManager.instance.Play("DragonDamage");
        }
    }
}
