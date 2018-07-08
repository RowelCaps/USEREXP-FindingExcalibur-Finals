using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetFollowPlayer : MonoBehaviour {
	
	private GameObject wayPoint;
	private Vector3 wayPointPos;
	//pet speed
	private float speed = 5.0f;

	public GameObject player2;

	public PetFollowPlayer player2Move;

	public bool petFollowingPlayer = false;

	void Start()
	{
		player2Move = player2.GetComponent<PetFollowPlayer>();

		wayPoint = GameObject.Find("Waypoint");
		petFollowingPlayer = true;
	}

	void FixedUpdate()
	{
		wayPointPos = new Vector3(wayPoint.transform.position.x, wayPoint.transform.position.y, wayPoint.transform.position.z);

		transform.position = Vector3.MoveTowards(transform.position, wayPointPos, speed * Time.deltaTime);
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if(col.gameObject.tag == "Player")
		{
			petFollowingPlayer = false;
			player2Move.enabled = false;
		}
	}

	void OnCollisionExit2D(Collision2D col)
	{
		if(col.gameObject.tag == "Player")
		{
			petFollowingPlayer = true;
			player2Move.enabled = true;
		}
	}
}


