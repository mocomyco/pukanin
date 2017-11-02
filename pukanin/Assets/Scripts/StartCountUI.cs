using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartCountUI : MonoBehaviour {
    public AudioSource Count;
    private bool OnAwake;
    public bool KaishiBool;
	// Use this for initialization
	void Start () {
        Invoke("Destroy", 1);
        if (KaishiBool == true)
        {
            GameSystem GS = GameObject.Find("GameSystem").GetComponent<GameSystem>();
            GS.gameState = GameSystem.GameState.ISPLAYING;
        }
    }
	
	// Update is called once per frame
	void Update () {
        
	}

    void Destroy()
    {
        
        Destroy(gameObject);
    }
}
