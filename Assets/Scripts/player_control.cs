using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_control : MonoBehaviour
{
    public bool grounded;
	public Rigidbody rb;
	public int speed;
	public int jump;
	
	// Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
		grounded = true;
		speed = 6;
		jump = 50;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	void Move()
	{
		rb.AddTorque( 0, Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0);

		if (Input.GetButtonDown("Jump") & grounded)
		{
			rb.AddForce(Input.GetAxis("Horizontal") * speed * Time.deltaTime, jump,0);
			grounded = false;
		}
		
	}
}
