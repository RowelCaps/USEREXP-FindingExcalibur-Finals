using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle4_Manager : MonoBehaviour {

    public GameObject Puzzle4Door;

    private tetrisBlue tb;
    private tetrisGreen tg;
    private tetrisRed tr;
    private tetrisYellow ty;

    public List<GameObject> PuzzleTetris = new List<GameObject>();
    

    // Use this for initialization
    void Start () {
        tb = PuzzleTetris[0].GetComponent<tetrisBlue>();
        ty = PuzzleTetris[1].GetComponent<tetrisYellow>();
        tr = PuzzleTetris[2].GetComponent<tetrisRed>();
        tg = PuzzleTetris[3].GetComponent<tetrisGreen>();
    }
	
	// Update is called once per frame
	void Update () {
		if(tb.bluePiece == true && tg.greenPiece == true && tr.redPiece == true && ty.yellowPiece == true)
        {
            Debug.Log("open");
            Puzzle4Door.SetActive(false);
        }
	}
}
