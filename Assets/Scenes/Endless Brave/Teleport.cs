using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    

    public Transform destination, player;
    public GameObject playerg;

    private void OnTriggerEnter(Collider other)
    {
                //Debug.Log("Player collided with flower");

        if (other.CompareTag("Player"))
        {
            playerg.SetActive(false);
            player.position = destination.position;
            playerg.SetActive(true);
        }
    }
}