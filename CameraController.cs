using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    //public Transform backgound;

    public Transform playerTransform;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var x = playerTransform.position.x + 4f;
        var y = playerTransform.position.y + 6f;
        transform.position = new Vector3(x, y, transform.position.z);

        //backgound.position = new Vector3(transform.position.x, transform.position.y, backgound.position.z);
    }
}