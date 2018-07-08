using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle1 : MonoBehaviour {
    public GameObject playerfeedback;

	// Use this for initialization
	void Start () {
        playerfeedback.SetActive(false);
	}

    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Door")
        {
            playerfeedback.SetActive(true);
            playerfeedback.GetComponent<TextMesh>().text = "Count your blessings.";
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        playerfeedback.SetActive(false);
    }

}
