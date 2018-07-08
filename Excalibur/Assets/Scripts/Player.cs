using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class Player : MonoBehaviour {

    [SerializeField] private float speed = 1.0f;

    private Vector2 direction;
    private Vector2 prevDirection;
    private bool isNearObject = false;
    private bool isInteractingObject = false;

    // Use this for initialization

    public bool IsInteractingObject
    {
        get{ return isInteractingObject;}

        set { isInteractingObject = value; }
    }

    public Vector2 PrevDirection
    {
        get { return prevDirection; }
    }

    void Start () {
        GetComponent<Rigidbody2D>().Sleep();
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
            isInteractingObject = true;
        else
            isInteractingObject = false;

        print(isInteractingObject);
    }

    private void FixedUpdate()
    {
        move();
    }

    private void move()
    {
        setDirection();
        transform.Translate(direction * speed * Time.deltaTime);
        //prevDirection = direction;
        direction = Vector2.zero;
        GetComponent<Rigidbody2D>().velocity = Vector2.zero;
    }

    private void setDirection()
    {
        if (Input.GetKey(KeyCode.W)) direction = Vector2.up;
        else if (Input.GetKey(KeyCode.A)) direction = Vector2.left;
        else if (Input.GetKey(KeyCode.S)) direction = Vector2.down;
        else if (Input.GetKey(KeyCode.D)) direction = Vector2.right;

        prevDirection = direction;
    }

    private void interact()
    {
        //code for interact
        isInteractingObject = true;
        //test
        //Destroy(objectInteract);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //change the tag for object to interact;
        if (collision.gameObject.CompareTag("Respawn"))
        {
            isNearObject = true;
            print("Near object");
            print("object Colliding");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        //tag is for testing.
        if (collision.gameObject.CompareTag("Respawn"))
        {
            isNearObject = false;
        }
    }

}
