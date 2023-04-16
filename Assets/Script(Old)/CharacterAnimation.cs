using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimation : MonoBehaviour
{
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    public void Walk(bool walk)
    {
        anim.SetBool("Walk", walk);
    }
    public void Attack_1()
    {
        anim.SetTrigger(AnimationTags.ATTACK_TRIGGER_1);
    }
}
