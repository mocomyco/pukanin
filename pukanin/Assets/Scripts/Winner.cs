using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Winner : MonoBehaviour {
    public Text Win;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (GameSystem.WinNum == 1)
        {
            Win.text = "1Pの勝利！";
        }

        if (GameSystem.WinNum == 2)
        {
            Win.text = "2Pの勝利！";
        }
	}
}
