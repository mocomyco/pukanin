using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSystem : MonoBehaviour {
   public enum GameState
    {
        START,
        ISPLAYING,
        FINISH,
    }
    public string Winner;
    public GameState gameState;
    static public int WinNum;
    public SceneTransitionExample S;
	// Use this for initialization
	void Start () {
        Winner = "yet";
        gameState = GameState.START;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void GameStart() {
        gameState = GameState.START;
    }

    void Finish(string Player)
    {
        if (Player == "Player1")
        {
            Winner = "Player2";
            WinNum = 2;

        }
            
        if (Player == "Player2")
        {
            Winner = "Player1";
            WinNum = 1;
        }
            
        gameState = GameState.FINISH;
        S.ChangeScene();
    }
}
