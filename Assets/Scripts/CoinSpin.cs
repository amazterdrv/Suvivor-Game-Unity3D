using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpin : MonoBehaviour {
    AudioSource audi;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.Rotate(0, 0, 10);
        //transform.Translate(1, 0, 0);
	}

    private void OnTriggerEnter(Collider other)
    {
        audi = GetComponent<AudioSource>();
        audi.Play();
        StartCoroutine(Wait());
      
        
    }

    IEnumerator Wait()
    {
       
        yield return new WaitForSeconds(0.5f);
        Destroy(gameObject);
        CoinCounter.count += 1;
    }
}
