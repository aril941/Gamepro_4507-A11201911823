using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthPlayer : MonoBehaviour
{

	public int maxHealth = 100;
	public int currentHealth;
	public static bool gameOver;
	public HealthBar healthBar;
	public GameObject gameOverPanel;

    // Start is called before the first frame update
    void Start()
    {
		currentHealth = maxHealth;
		healthBar.setMaxHealth(maxHealth);
		gameOver = false;
    }

    void Update(){
    	if (currentHealth == 0){
    		gameOver = true;
    		gameOverPanel.SetActive(true);
    		Time.timeScale = 0.5f;
    	}
    }

    public void OnTriggerEnter2D(Collider2D other){
    	if(other.CompareTag("Enemy")){
    		TakeDamage(10);
    	}
		
		else if(other.CompareTag("EnemyLife")){
    		TakeDamage(15);
    	}
    	else if(other.CompareTag("potion")){
    		healthUp(5);
    	}
    }

	void TakeDamage(int damage)
	{
		currentHealth -= damage;

		healthBar.setHealth(currentHealth);
	}

	void healthUp(int hp){
		currentHealth +=hp;
		healthBar.setHealth(currentHealth);
	}
}
