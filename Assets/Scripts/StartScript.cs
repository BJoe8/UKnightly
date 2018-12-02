using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScript : MonoBehaviour {

    void OnGUI()
    {
        GUI.Label(new Rect(Screen.width / 2 - 40, 50, 80, 80), "NOT ENOUGH SLEEP");

        if (GUI.Button(new Rect(Screen.width / 2 - 30, 300, 90, 30), "New Game"))
        {
            Application.LoadLevel(1);
        }
        if (GUI.Button(new Rect(Screen.width / 2 - 30, 350, 90, 30), "Exit Game"))
        {
            Application.Quit();
        }
    }
}
