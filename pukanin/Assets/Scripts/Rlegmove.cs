using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rlegmove : MonoBehaviour {
    public GameObject Rlegbox;
    public Rigidbody rigbody;
    public GameObject player;
    public GameObject bodyIK;
    Vector3 locvel;

    public enum Player
    {
        Player1,Player2,
    }

    [SerializeField]
    private Player PState;
	// Use this for initialization
	void Start () {
        //locvel = player.transform.InverseTransformDirection(rigbody.velocity);
	}
	
	// Update is called once per frame
	void Update () {
        switch (PState)
        {
            case Player.Player1:
                if (Input.GetAxis("Rstick yoko") + 0.2f > 0)
                {
                    Rlegbox.transform.localPosition = new Vector3(Input.GetAxis("Rstick yoko") + 0.2f, 0, -Input.GetAxis("Rstick tate"));
                    //bodyIK.transform.localPosition = new Vector3(Input.GetAxis("Rstick yoko"), 0.5f, -Input.GetAxis("Rstick tate"));
                }
                else
                {
                    Rlegbox.transform.localPosition = new Vector3(0, 0, -Input.GetAxis("Rstick tate"));
                }

                if (Input.GetAxis("Rstick yoko") > 0.2 || Input.GetAxis("Rstick tate") > 0.2 || Input.GetAxis("Rstick tate") < -0.2)
                {
                    //if (rigbody.velocity.x < 1 && (rigbody.velocity.z > -1 || rigbody.velocity.z < 1))
                    {
                        rigbody.velocity = Vector3.Lerp(((player.transform.right * Input.GetAxis("Rstick yoko")) + (player.transform.forward * -Input.GetAxis("Rstick tate"))) * 10
                            , new Vector3(0, 0, 0), 0.5f);

                    }
                    //rigbody.velocity += new Vector3(Input.GetAxis("Rstick yoko") / 3, 0, -Input.GetAxis("Rstick tate")/3);

                }
                else
                {
                    rigbody.velocity = Vector3.Lerp(rigbody.velocity, new Vector3(0, 0, 0), 0.00001f);
                }

                Debug.Log(Input.GetAxis("Rstick yoko"));
                break;
            case Player.Player2:
                if (Input.GetAxis("Player2RStick yoko") + 0.2f > 0)
                {
                    Rlegbox.transform.localPosition = new Vector3(Input.GetAxis("Player2RStick yoko") + 0.2f, 0, -Input.GetAxis("Player2RStick tate"));
                    //bodyIK.transform.localPosition = new Vector3(Input.GetAxis("Rstick yoko"), 0.5f, -Input.GetAxis("Rstick tate"));
                }
                else
                {
                    Rlegbox.transform.localPosition = new Vector3(0, 0, -Input.GetAxis("Player2RStick tate"));
                }

                if (Input.GetAxis("Player2RStick yoko") > 0.2 || Input.GetAxis("Player2RStick tate") > 0.2 || Input.GetAxis("Player2RStick tate") < -0.2)
                {
                    //if (rigbody.velocity.x < 1 && (rigbody.velocity.z > -1 || rigbody.velocity.z < 1))
                    {
                        rigbody.velocity = Vector3.Lerp(((player.transform.right * Input.GetAxis("Player2RStick yoko")) + (player.transform.forward * -Input.GetAxis("Player2RStick tate"))) * 10
                            , new Vector3(0, 0, 0), 0.5f);

                    }
                    //rigbody.velocity += new Vector3(Input.GetAxis("Rstick yoko") / 3, 0, -Input.GetAxis("Rstick tate")/3);

                }
                else
                {
                    rigbody.velocity = Vector3.Lerp(rigbody.velocity, new Vector3(0, 0, 0), 0.00001f);
                }

                // Debug.Log(Input.GetAxis("Rstick yoko"));
                break;
            default:
                break;
        }
       
	}
}
