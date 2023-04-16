using UnityEngine;
using System.Collections;

public class FBBehaviour : MonoBehaviour
{


    public AudioClip FireballSound;


    AudioSource AS;

    void Start()
    {
        AS = GetComponent<AudioSource>();
        AudioSource.PlayClipAtPoint(FireballSound, transform.position);
    }




}