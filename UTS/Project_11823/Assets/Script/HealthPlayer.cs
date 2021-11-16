using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthPlayer : MonoBehaviour
{

	public int maxHealth = 100;
	public int currentHealth;

	public HealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
		currentHealth = maxHealth;
		healthBar.setMaxHealth(maxHealth);
    }

    public void OnTriggerEnter2D(Collider2D other){
    	if(other.CompareTag("Enemy")){
    		TakeDamage(10);
    	}
    }

	void TakeDamage(int damage)
	{
		currentHealth -= damage;

		healthBar.setHealth(currentHealth);
	}
}
