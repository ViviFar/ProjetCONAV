using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetCameraPosition : MonoBehaviour {

    public Vector3 offset;
    public Transform anchor;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ResetPosition();
        }
    }

    public void ResetPosition()
    {
        transform.localPosition = -anchor.localPosition + offset;
    }


}
