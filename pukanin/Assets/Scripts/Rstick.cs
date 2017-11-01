﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rstick : MonoBehaviour {

    public GameObject body;
    public float speed = 0.3f;
    public Rigidbody rigbody;
    public GameObject L;
    public int limitflag = 1;
    public float limit = 0.9f;

    // Use this for initialization
    void Start ()
    {
        rigbody = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {

        Vector3 Lpos = L.transform.position;
        Vector3 Rpos = gameObject.transform.position;//足の位置定義
        float distance = Vector3.Distance(Lpos,Rpos);//２つの足の距離取得
        if (distance >= 1.1) { rigbody.AddForce((Lpos - Rpos)/2, ForceMode.VelocityChange); }
        if (distance <= 0.6) { rigbody.AddForce((Rpos - Lpos), ForceMode.VelocityChange); }

        float translationtate = Input.GetAxis("Rstick tate") * speed * Time.deltaTime;
        float translationyoko = Input.GetAxis("Rstick yoko") * speed * Time.deltaTime;

        var force = new Vector3(0,0,0);
        if (Input.GetAxis("Rstick tate") >= limit || Input.GetAxis("Rstick tate") <= -limit || Input.GetAxis("Rstick yoko") >= limit || Input.GetAxis("Rstick yoko") <= -limit)
        {
            if (limitflag == 0)
            {
                force.x = translationyoko;
                force.z = translationtate;
                limitflag = 1;
            }

        }
        else
        {
            force.x = translationyoko;
            force.z = translationtate;
            limitflag = 0;
        }
        //rigbody.velocity += force;
        transform.position += force;
        //force = (force+Vector3.zero)/2*Time.deltaTime;
        gameObject.transform.rotation = body.transform.rotation;
    }
}

