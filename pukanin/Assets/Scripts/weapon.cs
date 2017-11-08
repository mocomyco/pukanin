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
    [SerializeField] private bool _Switch;//長押し防止
    // Use this for initialization
    void Start () {
        GS = GameObject.Find("GameSystem").GetComponent<GameSystem>();
        _Switch = false;
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
<<<<<<< HEAD
                if (Input.GetAxis("LButton") == 1 || Input.GetAxis("RButton") == 1)
=======
                if (Input.GetButtonDown("LButton"))
>>>>>>> origin/etou
                {
                    if (Input.GetAxis("LButton") == 1 && _Switch == false)
                    {
                        Instantiate(buki, transform.position, transform.rotation);
                    }

<<<<<<< HEAD
                    //放物線クナイ
                    if (Input.GetAxis("RButton") == 1 && _Switch == false)
                    {
                        Instantiate(buki2, transform.position, transform.rotation);
                    }
                    _Switch = true;
                }
                else
=======
                //放物線クナイ
                if (Input.GetButtonDown("RButton"))
>>>>>>> origin/etou
                {
                    _Switch = false;
                }
                break;
            case Player.Player2:
                //直進クナイ
<<<<<<< HEAD
                if (Input.GetAxis("Player2LButton") == 1||Input.GetAxis("Player2RButton") == 1)
=======
                if (Input.GetButtonDown("Player2LButton"))
>>>>>>> origin/etou
                {
                    if (Input.GetAxis("Player2LButton") == 1&&_Switch ==false)
                    {
                        Instantiate(buki, transform.position, transform.rotation);
                    }

<<<<<<< HEAD
                    //放物線クナイ
                    if (Input.GetAxis("Player2RButton") == 1 && _Switch == false)
                    {
                        Instantiate(buki2, transform.position, transform.rotation);
                    }
                    _Switch = true;
                }
                else
=======
                //放物線クナイ
                if (Input.GetButtonDown("Player2RButton"))
>>>>>>> origin/etou
                {
                    _Switch = false;
                }
                break;
            default:
                break;
        }
        

        
    }

 }
