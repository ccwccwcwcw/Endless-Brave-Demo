using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PullSwordLoad : MonoBehaviour
{
    public string loadLevel;

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "OHSword")
        {
            SceneManager.LoadScene(loadLevel);
        }
        
    }

}