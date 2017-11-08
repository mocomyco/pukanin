using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kunai : MonoBehaviour {
    public float speed;//速さ
    float dellTime = 1.0f;
    public int damageValue = 10;
    private AudioSource aSourse;
    private AudioSource KunaiButukari;
    private float count = 0;
    // Use this for initialization
    void Start () {
        KunaiButukari = GameObject.Find("KunaiHit").GetComponent<AudioSource>();
		aSourse = GameObject.Find("Kunai1").GetComponent<AudioSource>();
        aSourse.Play();

    }
	
	// Update is called once per frame
	void Update () {
        count+=1*Time.deltaTime;
        transform.Translate(Vector3.forward * speed * Time.deltaTime);//移動
        if (count > 20)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter(Collider hit)
    {
        if(hit.gameObject.tag == "Player1")
        {
          hit.gameObject.SendMessage("Damaged",damageValue);
            Destroy(gameObject);//クナイ消去
        }

        if (hit.gameObject.tag == "Player2")
        {
            hit.gameObject.SendMessage("Damaged", damageValue);
            Destroy(gameObject);//クナイ消去
        }
        if (hit.gameObject.tag == "Damages")
        {
            KunaiButukari.Play();
            Destroy(gameObject);
        }

        if(hit.gameObject.tag == "wall")
        {
            
            Destroy(gameObject);
        }

        

    }
}
