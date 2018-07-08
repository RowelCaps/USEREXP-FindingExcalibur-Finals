using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

//THE GAMEOBJECT THAT IS PUSHABLE MUST BE KINEMATIC or STATIC AND IT SHALL NEVER MOVE

public class PressurePlatform : MonoBehaviour {

    [SerializeField] GameObject keyObject;
    [SerializeField] GameObject currentObjectOnTop; // <<---- for testing only yung serializefield
    [SerializeField] float distance = 1;

    [SerializeField]private bool isKeyObjectCorrect = false;

    public bool IsKeyObjectCorrect
    {
        get { return isKeyObjectCorrect; }
    }

    private void Awake()
    {
        // if this line has an error, please drag the corresponding rock para sa pressure platform
        Assert.IsNotNull(keyObject);
    }

    private void Update()
    {
        isKeyObjectOnTop();
    }

    private void isKeyObjectOnTop()
    {
        if (Vector2.Distance(transform.position, keyObject.transform.position) < distance)
            isKeyObjectCorrect = true;
        else
            isKeyObjectCorrect = false;
    }

}
