using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform playerTransform;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var x = playerTransform.position.x;
        var y = playerTransform.position.y;
        transform.position = new Vector3(x, y, transform.position.z);
    }
}
