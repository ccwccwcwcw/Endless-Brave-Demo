using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHP : MonoBehaviour
{
    public GameObject GameOverScreen;
    private int HP = 100;
    private void OnTriggerEnter(Collider other)
    {


        if (other.tag == "Dragon")
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
            GameOver();
        }
    }
    public void GameOver()
    {
        GameOverScreen.SetActive(true);
    }
}
