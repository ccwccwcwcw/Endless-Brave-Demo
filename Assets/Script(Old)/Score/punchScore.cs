using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class punchScore : MonoBehaviour
{
   
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Glover")
        {
            ScoreCount.UpdateScore(10);
        }
        if (other.gameObject.tag == "ball")
        {
            ScoreCount.UpdateScore(30);
        }

    }
}
