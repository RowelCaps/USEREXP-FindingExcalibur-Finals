using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleTwoPressurePad : MonoBehaviour {
	public GameObject Bridge;
	public GameObject WaterCollider;
    public GameObject Water;
	void Start()
	{
		Bridge.SetActive (false);
	}

	void Update()
	{
		if (Bridge.activeInHierarchy == false) {
			WaterCollider.SetActive (true);
            Water.SetActive(true);
        }
	}


	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "BridgePad") {
			Bridge.SetActive (true);
		}
		if (col.gameObject.CompareTag("Bridge"))
		{

			WaterCollider.SetActive (false);
            Water.SetActive(false);

		}
	}

    void OnCollisionStay2D(Collision2D col)
    {
        if(col.gameObject.tag == "Water")
        {
            this.gameObject.transform.Translate(0.0f, 3.0f, 0.0f);
        }
    }

	void OnTriggerExit2D(Collider2D col)
	{
		if (col.gameObject.tag == "BridgePad") {
			Bridge.SetActive (false);
		}

	}


}
