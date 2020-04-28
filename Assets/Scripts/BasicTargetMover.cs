using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicTargetMover : MonoBehaviour
{
    public enum MotionDirections { Horizontal , Spin , Vetical };

    public MotionDirections motionState = MotionDirections.Horizontal; 
    public float spinSpeed = 180.0f;
    public float motionMagnitude = 0.1f;
    


    // Update is called once per frame
    void Update()
    {
        switch(motionState)
        {
            case MotionDirections.Spin:
                gameObject.transform.Rotate(Vector3.up * spinSpeed * Time.deltaTime);
                break;
            case MotionDirections.Horizontal:
                gameObject.transform.Translate(Vector3.up * Mathf.Cos(Time.timeSinceLevelLoad) * motionMagnitude);
                break;
            case MotionDirections.Vetical:
                gameObject.transform.Translate(Vector3.right * Mathf.Cos(Time.timeSinceLevelLoad) * motionMagnitude);
                break;
        }
    }
}
