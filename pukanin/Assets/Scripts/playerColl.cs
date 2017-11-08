using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class playerColl : MonoBehaviour {

    /// <summary>
    /// このスクリプトにつけるTagをそれぞれPlayer1,2にすることで
    /// 当たり判定オブジェクトに自動的にTagを指定できる
    /// 
    /// 
    /// 
    /// </summary>
    public GameObject[] PlayerCollsNum;

    void Start () {
       for(int i = 0; i< PlayerCollsNum.Length; i++)
        {
            PlayerCollsNum[i].tag = gameObject.tag;
        }
	}
	
	// Update is called once per frame
	void Update () {
	
        	
	}
}
