using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScript : MonoBehaviour {

    int score = 0;
	// Use this for initialization
	void Start () {
        score = PlayerPrefs.GetInt("Score");
	}
	
	// Update is called once per frame
	void OnGUI () {
        GUI.Label(new Rect(Screen.width / 2 - 40, 50, 80, 30), "GAME OVER");

        GUI.Label(new Rect(Screen.width / 2 - 25, 300, 80, 30), "Score: " + score * 10);

        if (GUI.Button(new Rect(Screen.width / 2 - 30, 350, 60, 30), "Retry?"))
        {
            Application.LoadLevel(1);
        }
        if (GUI.Button(new Rect(Screen.width / 2 - 60, 400, 120, 30), "Return to Title"))
        {
            Application.LoadLevel(0);
        }
    }
}
 