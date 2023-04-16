using UnityEngine;
using System.Collections;

public class ISBehaviour : MonoBehaviour
{


    public AudioClip IceSpikeSound;


    AudioSource AS;

    void Start()
    {
        AS = GetComponent<AudioSource>();
        AudioSource.PlayClipAtPoint(IceSpikeSound, transform.position);
    }




}