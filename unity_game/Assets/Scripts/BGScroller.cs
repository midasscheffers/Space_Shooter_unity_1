using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScroller : MonoBehaviour
{

    public float scollSpeed = 10.0f;
    public float tileSizeZ;

    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }
    


    void Update()
    {
        float newPos = Mathf.Repeat(Time.time * scollSpeed, tileSizeZ);
        transform.position = startPos + Vector3.forward * newPos;
    }
}
