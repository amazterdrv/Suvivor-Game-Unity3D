using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour {
    public float target = 0f;
    public float range = 5f;
    public int damage = 1;

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update() {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hitinfo;
        if (Input.GetButtonDown("Fire1"))
        {
            if (Physics.Raycast(ray, out hitinfo))
            {
                target = hitinfo.distance;
                if (target <= range)
                {
                    Debug.DrawLine(ray.origin, hitinfo.point, Color.red);
                    if(hitinfo.collider.GetComponent("EnemyScript")!=null)
                    {
                        EnemyScript.health -= damage;
                    }

                }  
            }
            else
            {
                Debug.DrawLine(ray.origin, ray.origin + ray.direction * 100, Color.green);
            }
        }
    }
}
