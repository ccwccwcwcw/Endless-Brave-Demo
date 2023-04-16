using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitDummy : MonoBehaviour
{
    [SerializeField] private Animator anim;

    private void OnTriggerEnter(Collider other)
    {
        anim.SetBool("playPushed", true);
    }
    private void OnTriggerExit(Collider other)
    {
        anim.SetBool("playPushed", false);
    }
}
