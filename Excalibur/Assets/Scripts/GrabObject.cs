using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class GrabObject : MonoBehaviour {

    [SerializeField] private Transform player;
    [SerializeField] private float speed = 2f;
    [SerializeField] private List<GrabObject> objectsNearArea;
 
    private bool isPlayerNear = false;
    private bool isGrabbed = false;

    public bool IsGrabbed { get { return isGrabbed; } }


    private void Awake()
    {
        Assert.IsNotNull(player);      // <<--- if this gives you error drag player gameobject to the inspector
    }

    private void Start()
    {
        GetComponent<Rigidbody2D>().freezeRotation = true;
    }

    private void Update()
    {
        if (isPlayerNear && Input.GetKey(KeyCode.E) && !isOtherObjectGrabbed())
        {
            isGrabbed = true;
            transform.parent = player;
        }
        else
        {
            transform.parent = null;
            isGrabbed = false;
        }
    }

    private bool isOtherObjectGrabbed()
    {
        foreach(GrabObject go in objectsNearArea)
        {
            if (go.IsGrabbed)
                return true;
        }

        return false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
            isPlayerNear = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
            isPlayerNear = false;
    }
}
