using UnityEngine;
using System.Collections;

public class LSBehaviour : MonoBehaviour
{


    public AudioClip LightningStrikeSound;


    AudioSource AS;

    void Start()
    {
        AS = GetComponent<AudioSource>();
        AudioSource.PlayClipAtPoint(LightningStrikeSound, transform.position);
    }




}