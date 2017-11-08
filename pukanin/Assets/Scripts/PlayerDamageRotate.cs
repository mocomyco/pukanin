using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamageRotate : MonoBehaviour {
    public int CollNum;//Xは1から
    public Vector3[] RotateVec = new Vector3[] {new Vector3(1,0,0), new Vector3(1, 0, 1), new Vector3(0, 0, 1), new Vector3(-1, 0, 1), new Vector3(-1, 0, 0), new Vector3(-1, 0, -1), new Vector3(0, 0, -1), new Vector3(1, 0, -1), };
    public PlayerSlope PSlope;
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider hit)
    {
        if(hit.tag == "Damages")
        {
            Debug.Log("当たった" + RotateVec);
            PSlope.SendMessage("Slope", RotateVec[CollNum]);
        }
    }

   public void Damaged(int val)
    {
        PSlope.Damaged(val);
    }
}
