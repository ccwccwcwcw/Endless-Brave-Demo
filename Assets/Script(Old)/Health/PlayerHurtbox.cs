using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerHurtbox : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public GameObject m_GotHitScreen;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Fist")
        {
            gotHurt();
            playerHealth.TakeDamage(10);
        }
        
    }

    void gotHurt()
    {
        var color = m_GotHitScreen.GetComponent<Image>().color;
        color.a = 0.8f;

        m_GotHitScreen.GetComponent<Image>().color = color;
    }

    void Update()
    {
        if(m_GotHitScreen != null)
        {
            if(m_GotHitScreen.GetComponent<Image>().color.a > 0)
            {
                var color = m_GotHitScreen.GetComponent<Image>().color;
                color.a -= 0.01f;
                m_GotHitScreen.GetComponent<Image>().color = color;
            }

        }

    }
}
