using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame() {
    	SceneManager.LoadScene(1);
    }

    public void Back() {
    	Debug.Log("Back pressed");
    	SceneManager.LoadScene(0);
    }

    public void options() {
    	Debug.Log("Options pressed");
    	SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
}
