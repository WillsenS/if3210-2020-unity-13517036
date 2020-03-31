using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetScore : MonoBehaviour
{
	public Text txt;
	public static int score = 0;
    void Start()
    {
    	txt = GetComponent<Text> ();
    }

    void Update(){
    	txt.text = score.ToString();
    }
}
