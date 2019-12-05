using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermoverment : MonoBehaviour {
    [SerializeField]
    float speed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(horizontalInput,verticalInput,0) * Time.deltaTime * speed);
	}
}
