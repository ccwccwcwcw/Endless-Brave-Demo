using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{

	public int maxHealth = 100;
	public int currentHealth;

	public HealthBar healthBar;

	public Animator enemyAnim;

	
	void Start()
	{
		currentHealth = maxHealth;
		healthBar.SetMaxHealth(maxHealth);
	}

	
	void Update()
	{
		
	}

	public void TakeDamage(int damage)
	{
		currentHealth -= damage;
		enemyAnim.Play("Hurt");

		if (currentHealth <= 0)
		{
			enemyAnim.Play("dead");
			FindObjectOfType<GameManager>().YouWin();
		}


		healthBar.SetHealth(currentHealth);

		
	}
}
