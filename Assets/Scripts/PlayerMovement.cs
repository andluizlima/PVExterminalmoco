using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public float speed;
	public float rotationSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += Time.deltaTime * speed * transform.forward * Input.GetAxis("Vertical");
		transform.RotateAround (transform.position, transform.up, Input.GetAxis("Horizontal") * Time.deltaTime * rotationSpeed);
	}
}
