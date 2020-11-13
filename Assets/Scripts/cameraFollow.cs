using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    public Transform target;
    // public float smoothSpeed = 0.3f;
    
    // public Vector3 currentVelocity; 

    void LateUpdate()
    {
        // this will change the position of the camera to the y of the player
        // if the player.y > camera.y
        if(target.position.y > transform.position.y){
            Vector3 newPos = new Vector3(transform.position.x, target.position.y, transform.position.z);
            transform.position = newPos;
            // smooth damp for camera
            // transform.position = Vector3.SmoothDamp(transform.position, newPos, ref currentVelocity, smoothSpeed * Time.deltaTime);
            // lerp allows for smooth camera behavior- transition from old to new position smoothly
            // Vector3.Lerp(transform.position,newPos,smoothSpeed);
        }
    }
}
