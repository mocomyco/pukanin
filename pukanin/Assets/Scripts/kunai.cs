using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kunai : MonoBehaviour {
    public float speed;//速さ
    float dellTime = 1.0f;
    public int damageValue = 10;
    private AudioSource aSourse;
    // Use this for initialization
    void Start () {
		aSourse = GameObject.Find("Kunai1").GetComponent<AudioSource>();
        aSourse.Play();

    }
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);//移動
    }

    void OnTriggerEnter(Collider hit)
    {
        if(hit.gameObject.tag == "Player1")
        {
            hit.gameObject.GetComponent<PlayerSlope>().Damaged(damageValue);
            Destroy(gameObject);//クナイ消去
        }

        if (hit.gameObject.tag == "Player2")
        {
            hit.gameObject.GetComponent<PlayerSlope>().Damaged(damageValue);
            Destroy(gameObject);//クナイ消去
        }

        if(hit.gameObject.tag == "wall")
        {
            
            Destroy(gameObject);
        }

        

    }
}
