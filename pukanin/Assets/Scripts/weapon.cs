using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour {
    public GameObject buki;
    public GameObject buki2;
    public enum Player
    {
        Player1,Player2,
    }
    [SerializeField]
    private Player player;
    private GameSystem GS;
    // Use this for initialization
    void Start () {
        GS = GameObject.Find("GameSystem").GetComponent<GameSystem>();
    }
	
	// Update is called once per frame
	void Update () {

        if(GS.gameState == GameSystem.GameState.ISPLAYING)Act();
     
	}

    void Act() {
        switch (player)
        {
            case Player.Player1:
                //直進クナイ
                if (Input.GetButtonDown("LButton"))
                {
                    Instantiate(buki, transform.position, transform.rotation);
                }

                //放物線クナイ
                if (Input.GetButtonDown("RButton"))
                {
                    Instantiate(buki2, transform.position, transform.rotation);
                }
                break;
            case Player.Player2:
                //直進クナイ
                if (Input.GetButtonDown("Player2LButton"))
                {
                    Instantiate(buki, transform.position, transform.rotation);
                }

                //放物線クナイ
                if (Input.GetButtonDown("Player2RButton"))
                {
                    Instantiate(buki2, transform.position, transform.rotation);
                }
                break;
            default:
                break;
        }
        

        
    }

 }
