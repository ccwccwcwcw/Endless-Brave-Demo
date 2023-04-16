using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhitSFX : MonoBehaviour
{
    public AudioClip[] clipArray;
    public AudioSource effectSource;
    private int clipIndex;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Fist")
        {
            PlayRandom();
        }
    }

    void PlayRandom()
    {
        clipIndex = Random.Range(0, clipArray.Length);
        effectSource.PlayOneShot(clipArray[clipIndex]);
    }

}
