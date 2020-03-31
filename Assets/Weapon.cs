using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bullet;
    public Animator animator;
    public AudioSource audio;
	IEnumerator waiter()
	{
	    yield return new WaitForSeconds(0.1f);
	    animator.SetBool("isShooting", false);
	}
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) {
        	animator.SetBool("isShooting", true);
        	audio.Play();
        	Shoot();
        }
    }

    void Shoot() {
 		Instantiate(bullet, firePoint.position, firePoint.rotation);
 		StartCoroutine(waiter());
    }
}
