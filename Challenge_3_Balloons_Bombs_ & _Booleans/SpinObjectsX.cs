using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinObjectsX : MonoBehaviour
{
    public float spinSpeed;
     private int zRange = 0;
    // Update is called once per frame
    void Update()
     {
        transform.Rotate(Vector3.up *spinSpeed * Time.deltaTime );
        if (transform.position.z < -zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zRange);
        }

        if (transform.position.z > zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }
    }
}
