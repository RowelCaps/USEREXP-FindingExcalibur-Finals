using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tetrisGreen : MonoBehaviour {

    public bool greenPiece = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "GreenTrigger")
            greenPiece = true;
    }


    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "GreenTrigger")
            greenPiece = false;

    }
}
