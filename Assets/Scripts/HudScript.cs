using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HudScript : MonoBehaviour {

    float playerScore = 0;
	// Update is called once per frame
	void Update () {
        playerScore += Time.deltaTime * 10;
	}
    public void IncreaseScore(int amt)
    {
        playerScore += amt;
    }
    void OnDisable()
    {
        PlayerPrefs.SetInt("Score", (int)playerScore);
    }
    private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 100, 30), "Score: " + (int)(playerScore) *10);
    }
}
