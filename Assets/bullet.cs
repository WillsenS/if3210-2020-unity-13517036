using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 20f;
    public Rigidbody2D rb;
	public int damage = 30;

    void Start()
    {
    	rb.velocity = transform.right * speed;
    }

    void OnTriggerEnter2D(Collider2D hitInfo) {
    	Enemy zombie = hitInfo.GetComponent<Enemy>();
    	if (zombie != null) {
    		zombie.takeDamage(damage);
    	}
    	Destroy(gameObject);
    }
}
