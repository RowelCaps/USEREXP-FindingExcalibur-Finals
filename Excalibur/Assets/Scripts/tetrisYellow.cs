using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tetrisYellow : MonoBehaviour {

    public bool yellowPiece = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "YellowTrigger")
            yellowPiece = true;
    }


    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "YellowTrigger")
            yellowPiece = false;

    }
}
