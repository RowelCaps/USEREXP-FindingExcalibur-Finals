using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Assertions;


//use box colliders, colliders must not be close enough to each other so player wont collide with the two buttons at the same time or it will bug
//I will change this code on monday, using colliders that has small distance together to interact with the same objects seems buggy.

//KeyNumber is the number corresponding to the button. it will open the door if this is equal to the current num and key num.

public class ButtonInteraction : MonoBehaviour
{

    [SerializeField] private int keyNumber;
    [SerializeField] private TextMesh displayNumber;

    private int currentNumber = 0;
   [SerializeField] private bool isKeyNumberCorrect = false;

    //just in case, 2 players are near object.
    private List<Player> player = new List<Player>();


    public bool IsKeyNumberCorrect
    {
        get { return isKeyNumberCorrect; }
    }

    private void Start()
    {
        displayNumber = GetComponent<TextMesh>();
        displayNumber.text = keyNumber.ToString();
    }

    private void Update()
    {
        objectEventListner();
        playerInteractionListener();
    }

    private void objectEventListner()
    {
        if (keyNumber == currentNumber)
            isKeyNumberCorrect = true;
        else
            isKeyNumberCorrect = false;

        displayNumber.text = currentNumber.ToString();
    }

    private void playerInteractionListener()
    {
        foreach (Player currentPlayer in player)
        {
            if (currentPlayer.IsInteractingObject)
            {
                currentNumber = currentNumber + 1 > 9 ? 0 : ++currentNumber;
            }
            currentPlayer.IsInteractingObject = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            player.Add(collision.gameObject.GetComponent<Player>());
        }

        print("trigger");
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            player.Remove(collision.gameObject.GetComponent<Player>());
        }
    }
}
