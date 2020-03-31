using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy : MonoBehaviour
{
    public int health = 20;
    public int damage = 10;
    public AudioSource audio;
    public void takeDamage(int damage) {
    	health -= damage;
    	if (health <= 0) {
    		TextScript.score += 1;
    		Die();
    	}
    }

    void Die() {
    	Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D hitInfo) {
    	Health player = hitInfo.GetComponent<Health>();
    	if (player != null) {
    		player.takeDamage(10);
    	}
    	Destroy(gameObject);
    }
}
