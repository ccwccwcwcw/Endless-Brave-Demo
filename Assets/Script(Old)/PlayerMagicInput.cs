using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMagicInput : MonoBehaviour
{
    private CharacterAnimation playerAnimation;
    void Start()
    {
        playerAnimation = GetComponent<CharacterAnimation>();
    }

    
    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.J))
        {
            playerAnimation.Attack_1();
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            playerAnimation.Attack_1();
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            playerAnimation.Attack_1();
        }

    }
}
