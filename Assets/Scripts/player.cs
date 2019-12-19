using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
	public int speed = 5;
	public int jump = 300;
	public bool grounded;

	public Rigidbody rb;

	// Start is called before the first frame update
	void Start()
	{
		rb = GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	void Update()
	{
		Move();
	}

	void OnCollisionEnter(Collision collision)
	{
		grounded = true;
	}



	// Move the player
	void Move()
	{
		if (grounded)
		{
			transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0, 0);
			transform.Translate(0,0,Input.GetAxis("Vertical") * speed * Time.deltaTime);
		}
		if (Input.GetButtonDown("Jump") & grounded)
		{
			rb.AddForce(Input.GetAxis("Horizontal") * speed * Time.deltaTime, jump, 0);
			grounded = false;
		}

	}

}