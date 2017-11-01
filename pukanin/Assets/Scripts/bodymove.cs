using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bodymove : MonoBehaviour {

    public GameObject Rfoot;
    public GameObject Lfoot;
    public float bodyX;
    public float bodyZ;
    public int distanceflag = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
       bodyX = (Rfoot.transform.position.x + Lfoot.transform.position.x) / 2;
       bodyZ = (Rfoot.transform.position.z + Lfoot.transform.position.z )/ 2;
        gameObject.transform.position = new Vector3(bodyX,gameObject.transform.position.y,bodyZ);
        Vector3 footvec = (Rfoot.transform.position - Lfoot.transform.position);

        Vector3 Lpos = Lfoot.transform.position;
        Vector3 Rpos = Rfoot.transform.position;

        float distance = Vector3.Distance(Lpos, Rpos);//２つの足の距離取得
        if (distanceflag == 0 && gameObject.transform.position.y <= 1.06)
        {
            if (distance <= 6)
            {
                distanceflag = 1;
                gameObject.transform.Translate(0, (20 / distance * 2) * Time.deltaTime / 3, 0);
            }

        }
        else if(distance>=1.8){
            distanceflag = 0;
            float defoposy = 0.75f;
            var defaultposition = new Vector3(transform.position.x,defoposy,transform.position.z);
            gameObject.transform.SetPositionAndRotation(defaultposition,transform.rotation);
        }

        //gameObject.transform.rotation = footvec;
        //footvec.y = 0;
        footvec.x = 0;
        footvec.z = 0;
        transform.localEulerAngles += footvec ;
        //transform.eulerAngles =footvec ;
    }
}
