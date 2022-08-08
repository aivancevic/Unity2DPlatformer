using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    private Transform myTransform;  //optimization

    private void Awake()
    {
        myTransform = GetComponent<Transform>();

        if (myTransform == null)
        {
            Debug.LogError("Script: CameraFollow\t myTransform 2D is NULL");
        }
    }

    void LateUpdate()
    {
        if (target != null && target.position.y > myTransform.position.y)
        {
            Vector3 newPos = new Vector3(myTransform.position.x, target.position.y, myTransform.position.z);
            myTransform.position = newPos;
        }
    }
}
