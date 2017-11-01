using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour {
    // Use this for initialization
    public Rigidbody rigbody;
    public GameObject bodyIK;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        bodyIK.transform.localPosition = new Vector3(Input.GetAxis("Rstick yoko") + Input.GetAxis("Lstick yoko"), 0.5f, -Input.GetAxis("Lstick tate") + -Input.GetAxis("Rstick tate"));

        //transform.localEulerAngles = new Vector3(0, 0, 0);
        if (Input.GetAxis("Lstick tate") < 0 && Input.GetAxis("Rstick tate") > 0)
        {
            Debug.Log("1");
            transform.localEulerAngles += new Vector3(0, 1f, 0);
        }

        else if (Input.GetAxis("Lstick tate") > 0 && Input.GetAxis("Rstick tate") < 0)
        {
            transform.localEulerAngles += new Vector3(0, -1f, 0);
        }

        else
        {
            //transform.Rotate(0, 0, 0);
        }
    }

    void OnCollisionStay( Collision hit)
    {
        //transform.localEulerAngles = new Vector3(0, 0, 0);
        Debug.Log(hit);
        //rigbody.velocity = Vector3.zero;
        rigbody.constraints = RigidbodyConstraints.FreezeRotation;
    }
}
