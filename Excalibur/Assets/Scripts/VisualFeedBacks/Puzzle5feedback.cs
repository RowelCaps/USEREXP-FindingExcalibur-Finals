using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle5feedback : MonoBehaviour {
    public GameObject playerfeedback;
    // Use this for initialization
    void Start () {
        playerfeedback.SetActive(false);
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "PetDoor")
        {
            playerfeedback.SetActive(true);
            playerfeedback.GetComponent<TextMesh>().text = "Use Your Pet!";
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "PetDoor")
        {
            playerfeedback.SetActive(false);
           
        }
    }
}
