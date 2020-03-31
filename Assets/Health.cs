using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
	public int MaxHealth = 100;
    public int health = 100;
    public HealthBar healthbar;
    public Animator animator;
    public GameObject death;

	public void start() {
		health = MaxHealth;
		healthbar.SetMaxHealth(MaxHealth);
	}

    public void takeDamage(int damage) {
    	health -= damage;
    	healthbar.SetHealth(health);
    	if (health <= 0) {
    		animator.SetBool("isDead", true);
    		Die();
    	}
    }

    void Die() {
    	Instantiate(death,transform.position, Quaternion.identity);
    	Destroy(gameObject);
    	SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}