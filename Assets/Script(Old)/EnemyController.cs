using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public enum EnemyState
{
    CHASE,
    ATTACK
}

public class EnemyController : MonoBehaviour
{
    private CharacterAnimation enemy_Anim;
    private NavMeshAgent navAgent;

    private Transform playerTarget;
    public float move_Speed = 3.5f;

    private EnemyState enemy_State;

    void Awake()
    {
        enemy_Anim = GetComponent<CharacterAnimation>();
        navAgent = GetComponent<NavMeshAgent>();
        playerTarget = GameObject.FindWithTag(Tags.PLAYER_TAG).transform;
    }

    private void Start()
    {
        enemy_State = EnemyState.CHASE;
  
    }
    void Update()
    {
        if(enemy_State == EnemyState.CHASE)
        {
            ChasePlayer();
        }
       
    }
    void ChasePlayer()
    {
        navAgent.SetDestination(playerTarget.position);
        navAgent.speed = move_Speed;
        if(navAgent.velocity.sqrMagnitude == 0)
        {
            enemy_Anim.Walk(false);
        }
        else
        {
            enemy_Anim.Walk(true);
        }

    }
}








