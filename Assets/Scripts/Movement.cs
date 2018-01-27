using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public float speed = 2f;

	// Use this for initialization
	void Start () {
		
	}
	
    void FixedUpdate()
    {
        transform.position += transform.right * Input.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.position += transform.up * Input.GetAxis("Horizontal") * speed * Time.deltaTime;
    }

}
