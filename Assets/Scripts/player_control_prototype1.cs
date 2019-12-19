using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_control : MonoBehaviour
{
    private bool grounded;
	private Rigidbody rb;
	public int speed = 600;
	public int jump = 150;

	// Start is called before the first frame update
	void Start()
    {
        rb = GetComponent<Rigidbody>();
		grounded = true;
    }

    // Update is called once per frame
    void Update()
    {
		Move();
    }
	
	void Move()
	{
		rb.AddTorque( 0, Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0);
		float forward_axis = Input.GetAxis("Vertical") * speed * Time.deltaTime;
		rb.AddForce(transform.forward * forward_axis);

		if (Input.GetButtonDown("Jump") & grounded)
		{
			rb.AddForce(Input.GetAxis("Horizontal") * speed * Time.deltaTime, jump,0);
			grounded = false;
		}
		
	}

	private void OnCollisionEnter(Collision collision)
	{
		grounded = true;
	}
}
