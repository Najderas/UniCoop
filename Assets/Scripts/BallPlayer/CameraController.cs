using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour, ICameraController
{

    public GameObject player;

    public Vector3 offset = new Vector3(0, 8, -10);
    public float speed = 5f;

    public void Init(GameObject player)
    {
        this.player = player;
    }

    // Use this for initialization
    void Start ()
	{
        //offset = transform.position - player.transform.position;
        //offset = new Vector3(0, 8, -10);
	}
	
	// Update is called once per frame
	void LateUpdate ()
	{
        if (!player) return;

        //transform.position = player.transform.position + offset;

        transform.position = Vector3.Lerp(transform.position, player.transform.position + offset, Time.deltaTime * speed);
    }

}
