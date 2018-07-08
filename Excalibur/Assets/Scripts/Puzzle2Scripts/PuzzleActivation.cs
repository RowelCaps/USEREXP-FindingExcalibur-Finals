using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleActivation : MonoBehaviour {
	public PlayerWaypoint player1Controller;
	public PetFollowPlayer Player2Controller;

	public GameObject player1;
	public GameObject player2;
    public GameObject petFeedback;

	public bool entered;

	void start()
	{
		player1Controller = player1.GetComponent<PlayerWaypoint>();
		Player2Controller = player2.GetComponent<PetFollowPlayer>();
        petFeedback.SetActive(false);
    }

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "TwoPlayerZone")
		{
			entered = true;
			player1Controller.enabled = false;
			Player2Controller.enabled = false;
            petFeedback.SetActive(true);
            petFeedback.GetComponent<TextMesh>().text = "*BARK**BARK*";
        }
	}

    void OnTriggerStay2D(Collider2D col)
    {
        if(col.gameObject.tag == "TwoPlayerZone")
        {
            player1Controller.enabled = false;
            Player2Controller.enabled = false;
            
        }
    }

    void OnTriggerExit2D(Collider2D col)
	{
		if(col.gameObject.tag == "TwoPlayerZone")
		{
			entered = false;
			player1Controller.enabled = true;
			Player2Controller.enabled = true;
            petFeedback.SetActive(false);
        }
	}
}
