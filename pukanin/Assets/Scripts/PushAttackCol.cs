using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushAttackCol : MonoBehaviour {
    //public enum Player
    //{
    //    Player1,Player2,
    //}
    //[SerializeField]
    //private Player Your;
    public int damageValue;
    public AudioSource aSource;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider hit)
    {
        if (hit.gameObject.tag == "Player")
        {
            hit.gameObject.GetComponent<PlayerSlope>().Damaged(damageValue);
            
        }

    }
}
