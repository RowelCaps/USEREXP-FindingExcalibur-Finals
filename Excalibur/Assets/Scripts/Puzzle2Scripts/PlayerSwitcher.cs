using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSwitcher : MonoBehaviour {
	public GameObject player1;
	public GameObject player2;

	public Player player1Input;
	public Player player2Input;

	public bool player1Active = false;
	public bool player2Active = false;

	public GameObject defaultCamera;
    public GameObject cameraPlayer1;
    public GameObject cameraPlayer2;


    void Start()
	{
		player1Input = player1.GetComponent<Player>();
		player2Input = player2.GetComponent<Player>();
		player1Active = true;
		player2Active = false;

	}



	void Update()
	{
		if (Input.GetKeyDown("1"))
		{
			player1Active = true;
			player2Active = false;
            cameraPlayer1.SetActive(true);
            cameraPlayer2.SetActive(false);
        }

		if (Input.GetKeyDown("2"))
		{
			player2Active = true;
			player1Active = false;
            cameraPlayer1.SetActive(false);
            cameraPlayer2.SetActive(true);
        }

		if (player1Active == true)
		{
			SwitchToPlayer(player1Input, player2Input, cameraPlayer1);
            
		}

		if (player2Active == true)
		{
			SwitchToPlayer(player2Input, player1Input, cameraPlayer2);
          
		}

	}

	void SwitchToPlayer(Player inputToEnable, Player inputToDisable, GameObject cameraLocation)
	{

		inputToEnable.enabled = true;

		inputToDisable.enabled = false;

        defaultCamera.transform.position = cameraLocation.transform.position;
    }
}
