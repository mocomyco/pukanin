﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : MonoBehaviour {

    [SerializeField] private int damageValue = 10;

    private AudioSource Iwa;
    // Use this for initialization
    void Start()
    {
        Iwa = GameObject.Find("Iwa").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update () {
		
	}

    void OnTriggerEnter(Collider hit)
    {
        if (hit.gameObject.tag == "Player1"|| hit.gameObject.tag == "Player2")
        {
            Iwa.Play();
            hit.gameObject.GetComponent<PlayerSlope>().Damaged(damageValue);
        }
    }
}
