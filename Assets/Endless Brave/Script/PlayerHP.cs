using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR;
using UnityEngine.SceneManagement;

public class PlayerHP : MonoBehaviour
{
    public GameObject GameOverScreen;
    private int HP = 100;
    public string scenename;
    public XRController leftHandController;
    private void OnTriggerEnter(Collider other)
    {


        if (other.tag == "Dragon")
        {
            TakeDamage(20);
            Debug.Log("collision");
        }
    }
    public void TakeDamage(int damageAmount)
    {
        HP -= damageAmount;
        if (HP <= 0)
        {
            GameOverScreen.SetActive(true);
            Invoke("GameOver", 3);
        }
    }
    public void GameOver()
    {
        SceneManager.LoadScene(scenename);
    }
}
