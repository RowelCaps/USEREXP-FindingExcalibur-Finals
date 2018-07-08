using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//drag all buttons here
// it will check all the keynumber are equal to current num and activate event when it is all true

public class DoorPlatform : MonoBehaviour
{

    [SerializeField] private List<PressurePlatform> platforms;

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
        if (GetComponent<DoorButton>() != null)
            return;

        if (isPlatformCurrentCorrect())         //same as the button insert the code here for animation or disabling collider
            Destroy(this.gameObject);
    }

    private bool isPlatformCurrentCorrect()
    {
        int counter = 0;

        foreach (PressurePlatform platform in platforms)
        {
            if (platform.IsKeyObjectCorrect)
                counter++;
        }

        return counter == platforms.Count ? true : false;
    }

}
