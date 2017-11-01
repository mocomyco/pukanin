using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushHand : MonoBehaviour {
   private enum Hand
    {
        Idle,Attack, IsStunned
    }
    public enum Player
    {
        Player1,Player2,
    }
    [SerializeField] private float reach;
    [SerializeField] private Player player;

    private Hand handState;
    private float HandHoldCount = 0;
    private float HoldTime = 1.0f;
    public GameObject LeftHand, RightHand,Body;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(Input.GetAxis("LButton"));
        Debug.Log(Input.GetAxis("Player2LButton"));
        switch (player)
        {
            case Player.Player1:
                if(Input.GetAxis("LButton") == 1 && Input.GetAxis("RButton") == 1&& handState == Hand.Idle)
                {
                    handState = Hand.Attack;
                }
                break;
            case Player.Player2:
                if (Input.GetAxis("Player2LButton") == 1 && Input.GetAxis("Player2RButton") == 1 && handState == Hand.Idle)
                {
                    handState = Hand.Attack;
                }
                break;
            default:
                break;
        }

        switch (handState)
        {
            case Hand.Idle:
                HoldTime = 0;
                RightHand.transform.localPosition = new Vector3(0.5f, Body.transform.localPosition.y, Body.transform.localPosition.z);
                LeftHand.transform.localPosition = new Vector3(-0.5f, Body.transform.localPosition.y, Body.transform.localPosition.z);
                break;
            case Hand.Attack:
                HoldTime += 1 * Time.deltaTime;
                if (HoldTime > HandHoldCount) handState = Hand.Idle;
                RightHand.transform.localPosition = new Vector3(-0.2f, Body.transform.localPosition.y, Body.transform.localPosition.z+reach);
                LeftHand.transform.localPosition = new Vector3(+0.2f, Body.transform.localPosition.y, Body.transform.localPosition.z+reach);

                break;
            case Hand.IsStunned:
                //腕回転
                break;
            default:
                break;
        }
        
    }
}
