using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tetrisBlue : MonoBehaviour {


    public bool bluePiece = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "BlueTrigger")
            bluePiece = true;
    }


    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "BlueTrigger")
            bluePiece = false;

    }
}
