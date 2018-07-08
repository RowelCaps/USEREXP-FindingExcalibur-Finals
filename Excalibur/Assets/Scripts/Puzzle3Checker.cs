using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle3Checker : MonoBehaviour {
	public GameObject levelFourDoors;

	public GameObject puzzleOne;
	public GameObject puzzleTwo;
	public GameObject puzzleThree;

	public PressurePlatform puzzleOneScript;
	public PressurePlatform puzzleTwoScript;
	public PressurePlatform puzzleThreeScript;

	void Start()
	{
		puzzleOneScript = puzzleOne.GetComponent<PressurePlatform> ();
		puzzleTwoScript = puzzleTwo.GetComponent<PressurePlatform> ();
		puzzleThreeScript = puzzleThree.GetComponent<PressurePlatform> ();
	}

	void Update()
	{
		if (puzzleOneScript.IsKeyObjectCorrect == true && puzzleTwoScript.IsKeyObjectCorrect == true && puzzleThreeScript.IsKeyObjectCorrect == true) {
			levelFourDoors.SetActive (false);
		}
	}
}
