using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Title : MonoBehaviour {
    public bool Right,Left;
    public SceneTransitionExample S;
    public AudioSource Sei, Ha,Don,Dodon;
	// Use this for initialization
	void Start () {
        Right = false;
        Left = false;
	}
	
    void Update()
    {
        if(Left == true&&Right == true)
        {
            S.ChangeScene();
        }

        
        if (Input.GetAxis("LButton") == 1&& Input.GetAxis("RButton")==1)
        {
            Player1();
            Debug.Log("LRきたよ");
        }

        if (Input.GetAxis("Player2LButton") == 1 && Input.GetAxis("Player2RButton") == 1)
        {
            Player2();
            Debug.Log("LRきたよ");
        }
    }

	public void Player1()
    {
        Left = true;
        Sei.Play();
        if (Right == true)
        {
            Dodon.Play();
        }
        else Don.Play();
    }

    public void Player2()
    {
        Right = true;
        Ha.Play();
        if (Left == true)
        {
            Dodon.Play();
        }
        else Don.Play();
    }
}
