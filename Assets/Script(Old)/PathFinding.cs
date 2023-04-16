 using UnityEngine;
 using UnityEngine.AI;
using System.Collections;

public class PathFinding : MonoBehaviour
{
	public enum EnemyState{
		CHASE,
		ATTACK
	}

	NavMeshAgent NM;
	Transform Player;
	public float rotationSpeed = 2f;

	public float attack_Distance = 4.5f;
	public float chase_Distance = 4.5f;

	private float wait_Before_Attack = 2f;
	private float attack_Timer;

	private EnemyState enemy_State;
	Animator enemyAnim;
	public PlayerHealth playerHealth;



	void Start()
	{
		enemy_State = EnemyState.CHASE;
		attack_Timer = wait_Before_Attack;

		NM = GetComponent<UnityEngine.AI.NavMeshAgent>();
		Player = GameObject.FindWithTag("Player").transform;
		Transform target = Player;
		enemyAnim = GetComponent<Animator>();
	}

	void Update()
	{
		if(enemy_State == EnemyState.CHASE){
			ChasePlayer();
		}
		if(enemy_State == EnemyState.ATTACK){
			AttackPlayer();
		}

		
	}

	void ChasePlayer(){

		NM.SetDestination(Player.position);
		enemyAnim.SetTrigger("Walking");



		if (Vector3.Distance(transform.position, Player.position) <= attack_Distance){
		
			enemy_State = EnemyState.ATTACK;
		}
	}
	void AttackPlayer(){

		 NM.velocity = Vector3.zero;
		 RotateTowards(Player);
		enemyAnim.SetTrigger("Attack");



		attack_Timer += Time.deltaTime;
		if(attack_Timer > wait_Before_Attack){
			
		}

		attack_Timer = 0f;
		if (Vector3.Distance(transform.position, Player.position) > attack_Distance + chase_Distance){
			NM.isStopped = false;
			enemy_State = EnemyState.CHASE;

		}
	}
	private void RotateTowards(Transform target)
	{
		Vector3 direction = (target.position - transform.position).normalized;
		Quaternion lookRotation = Quaternion.LookRotation(direction);
		transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * rotationSpeed);

	}
}