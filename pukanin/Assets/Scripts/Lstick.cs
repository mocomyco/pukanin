using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lstick : MonoBehaviour {

    public GameObject body;
    public float speed = 0.3f;
    public Rigidbody rigbody;
    public GameObject R;
    public int limitflag = 1;
    public float limit = 0.9f;
    // Use this for initialization
    void Start()
    {
        rigbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 Lpos = gameObject.transform.position;
        Vector3 Rpos = R.transform.position;//足の位置定義
        float distance = Vector3.Distance(Lpos, Rpos);//２つの足の距離取得
        if (distance >= 1.1) { rigbody.AddForce((Rpos - Lpos) / 2, ForceMode.VelocityChange); }
        if (distance <= 0.6) { rigbody.AddForce((Lpos - Rpos) , ForceMode.VelocityChange); }


        float translationtate = Input.GetAxis("Lstick tate") * speed;
        Debug.Log(Input.GetAxis("Lstick tate"));
            float translationyoko = Input.GetAxis("Lstick yoko") * speed;
            translationtate *= Time.deltaTime;
            translationyoko *= Time.deltaTime;

            var force = new Vector3(0, 0, 0);
        if (Input.GetAxis("Lstick tate")>=limit|| Input.GetAxis("Lstick tate") <= -limit || Input.GetAxis("Lstick yoko") >= limit || Input.GetAxis("Lstick yoko") <= -limit )
        {
            if (limitflag==0)
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

            

        

            rigbody.AddForce(force, ForceMode.VelocityChange);
            //force = (force + Vector3.zero)/2 * Time.deltaTime;
        
            gameObject.transform.rotation = body.transform.rotation;
        
    }
}
