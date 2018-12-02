using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoveScript : MonoBehaviour {

    // Update is called once per frame
    void Update()
    {   
        // Get the camera's current position
        var tCameraPosn = transform.localPosition;
        transform.Translate(Time.deltaTime*5, 0, 0, Camera.main.transform);
        /*
        // Set the trigger altitude (above this we'll move the camera forward)
        var tTriggerAltitude = 0.0;

        // Check the camera's altitude (y-position) against the trigger altitude
        if (tCameraPosn.y < tTriggerAltitude)
        {

            // Move the camera up
            transform.Translate((Vector3.up * (float)(Time.deltaTime)), Space.World);

        }
        else
        {

            // Move the camera forward
            transform.Translate(Vector3.forward * (float)(Time.deltaTime));
        }
        */
    }
}
