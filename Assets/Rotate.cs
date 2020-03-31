using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    // Start is called before the first frame update
	float HorizontalMove = 0f;
    // Update is called once per frame
    void Update()
    {
        HorizontalMove = Input.GetAxisRaw("Horizontal");
        if (HorizontalMove < 0) {
        	transform.localScale = new Vector3(1f,1f,1f);
        }
    }
}
