using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sliding_effect : MonoBehaviour
{

    public Transform destination;
    public float moveSpeed = 20f;
    private float cpt;

    // Start is called before the first frame update
    void Start()
    {
        GameObject IRM_Pipe = GameObject.Find("IRM_pipe");
        destination = IRM_Pipe.transform;
        // destination.position = new Vector3(destination.position.x - 1, destination.position.y, destination.position.z);
        transform.position = new Vector3(6f, 0f, 6.69f);

        cpt = Math.Abs(Vector3.Distance(transform.position, destination.position)) + 1.5f;
    }

    // Update is called once per frame
    void Update()
    {

        var step = Time.deltaTime * moveSpeed;
        //if (Vector3.Distance(transform.position, destination.position) >= 0.1f)
        if (cpt > 0)
        {
            //transform.position = Vector3.MoveTowards(transform.position, destination.position, step);
            transform.Translate(0, 0, -step);
            cpt -= step;
        }
    }
}
