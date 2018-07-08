using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//drag all buttons here
// it will check all the keynumber are equal to current num and activate event when it is all true

public class DoorButton : MonoBehaviour{

    [SerializeField] private List<ButtonInteraction> buttons;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        triggerEvent();
    }

    private void triggerEvent()
    {
        if (GetComponent<DoorPlatform>() != null)
            return;

        if (isButtonNumberCorrect())        // insert code here for animation or disabling colliders
            Destroy(this.gameObject);       // destroy is just a test
    }

    private bool isButtonNumberCorrect()
    {
        int counter = 0;

        foreach (ButtonInteraction button in buttons)
        {
            if (button.IsKeyNumberCorrect)
                counter++;
        }

        return counter == buttons.Count ? true : false;
    }

}
