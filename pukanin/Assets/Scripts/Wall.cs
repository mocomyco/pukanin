using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour {

    public int damageValue = 5;
    private AudioSource aSourse;
  

    void Start()
    {
        aSourse = GameObject.Find("Wall").GetComponent<AudioSource>();
      

    }

    void OnTriggerEnter(Collider hit)
    {
        if (hit.gameObject.tag == "Player1")
        {
            aSourse.Play();
            hit.gameObject.SendMessage("Damaged", damageValue);
            
        }

        if (hit.gameObject.tag == "Player2")
        {
            aSourse.Play();
            hit.gameObject.SendMessage("Damaged", damageValue);
           
        }

    }

}
