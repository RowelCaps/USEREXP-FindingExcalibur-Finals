using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyObtain : MonoBehaviour {
	[SerializeField]private bool playerHasPuzzle2Key = false;
	[SerializeField]private bool playerHasPuzzle3Key = false;
	[SerializeField]private bool playerHasPuzzle4Key = false;
	[SerializeField]private bool playerHasPuzzle5Key = false;

	public GameObject excaliburDoor;
	public GameObject excaliburWalls;
	public GameObject excalibur;


	void Update()
	{
		if (playerHasPuzzle2Key == true && playerHasPuzzle3Key == true && playerHasPuzzle4Key == true && playerHasPuzzle5Key == true) {
			excaliburDoor.SetActive (true);
			excaliburWalls.SetActive (false);
			excalibur.SetActive (true);
		}
	}


	void OnCollisionEnter2D(Collision2D col)
	{
		if(col.gameObject.tag == "PuzzleTwoKey")
		{
			playerHasPuzzle2Key = true;

			Destroy (col.gameObject);
		}
		if(col.gameObject.tag == "PuzzleThreeKey")
		{
			playerHasPuzzle3Key = true;

			Destroy (col.gameObject);
		}
		if(col.gameObject.tag == "PuzzleFourKey")
		{
			playerHasPuzzle4Key = true;

			Destroy (col.gameObject);
		}
		if(col.gameObject.tag == "PuzzleFiveKey")
		{
			playerHasPuzzle5Key = true;

			Destroy (col.gameObject);
		}
	}
}
