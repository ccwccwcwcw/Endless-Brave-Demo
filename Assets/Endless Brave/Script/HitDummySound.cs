using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitDummySound : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip SwordHit;
    public AudioClip BluntHit;
    public AudioClip DaggerHit;
    public AudioClip ShieldHit;

    public void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "OHSword")
        {
            audioSource.PlayOneShot(SwordHit);
        }
        if (other.gameObject.tag == "OHAxe")
        {
            audioSource.PlayOneShot(SwordHit);
        }
        if (other.gameObject.tag == "OHHammer")
        {
            audioSource.PlayOneShot(BluntHit);
        }
        if (other.gameObject.tag == "OHMace")
        {
            audioSource.PlayOneShot(BluntHit);
        }
        if (other.gameObject.tag == "Dagger")
        {
            audioSource.PlayOneShot(DaggerHit);
        }
        if (other.gameObject.tag == "Shield")
        {
            audioSource.PlayOneShot(ShieldHit);
        }
    }
}
