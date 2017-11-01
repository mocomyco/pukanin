using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Llegmove : MonoBehaviour {
    public GameObject Llegbox;
    public Rigidbody rigbody;
    public GameObject player;
    public GameObject bodyIK;
    public enum Player
    {
        Player1, Player2,
    }

    [SerializeField]
    private Player PState;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        switch (PState)
        {
            case Player.Player1:
                if (Input.GetAxis("Lstick yoko") - 0.2f < 0)
                {
                    Llegbox.transform.localPosition = new Vector3(Input.GetAxis("Lstick yoko") - 0.2f, 0, -Input.GetAxis("Lstick tate"));
                    //bodyIK.transform.localPosition = new Vector3(Input.GetAxis("Lstick yoko"), 0.5f, -Input.GetAxis("Lstick tate"));
                }
                else
                {
                    Llegbox.transform.localPosition = new Vector3(0, 0, -Input.GetAxis("Lstick tate"));
                }

                if (Input.GetAxis("Lstick yoko") < -0.2 || Input.GetAxis("Lstick tate") > 0.2 || Input.GetAxis("Lstick tate") < -0.2)
                {
                    //if (rigbody.velocity.x > -1 && (rigbody.velocity.z > -1 || rigbody.velocity.z < 1))
                    {
                        //rigbody.velocity += new Vector3(Input.GetAxis("Lstick yoko") / 3, 0, -Input.GetAxis("Lstick tate") / 3);
                        rigbody.velocity += (player.transform.right * Input.GetAxis("Lstick yoko")) + (player.transform.forward * -Input.GetAxis("Lstick tate"));
                    }

                }
                break;
            case Player.Player2:
                if (Input.GetAxis("Player2LStick yoko") - 0.2f < 0)
                {
                    Llegbox.transform.localPosition = new Vector3(Input.GetAxis("Player2LStick yoko") - 0.2f, 0, -Input.GetAxis("Player2LStick tate"));
                    //bodyIK.transform.localPosition = new Vector3(Input.GetAxis("Lstick yoko"), 0.5f, -Input.GetAxis("Lstick tate"));
                }
                else
                {
                    Llegbox.transform.localPosition = new Vector3(0, 0, -Input.GetAxis("Player2LStick tate"));
                }

                if (Input.GetAxis("Player2LStick yoko") < -0.2 || Input.GetAxis("Player2LStick tate") > 0.2 || Input.GetAxis("Player2LStick tate") < -0.2)
                {
                    //if (rigbody.velocity.x > -1 && (rigbody.velocity.z > -1 || rigbody.velocity.z < 1))
                    {
                        //rigbody.velocity += new Vector3(Input.GetAxis("Lstick yoko") / 3, 0, -Input.GetAxis("Lstick tate") / 3);
                        rigbody.velocity += (player.transform.right * Input.GetAxis("Player2LStick yoko")) + (player.transform.forward * -Input.GetAxis("Player2LStick tate"));
                    }

                }
                break;
            default:
                break;
        }
        

    }
}
