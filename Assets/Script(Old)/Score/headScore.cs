using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class headScore : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Glover")
        {
            ScoreCount.UpdateScore(20);
        }
        if (other.gameObject.tag == "ball")
        {
            ScoreCount.UpdateScore(30);
        }
    }
}
