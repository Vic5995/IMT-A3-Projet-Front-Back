using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sliding_effect : MonoBehaviour
{

    public Transform destination;
    public float moveSpeed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        GameObject IRM_Pipe = GameObject.Find("IRM_pipe");
        destination = IRM_Pipe.transform;
    }

    // Update is called once per frame
    void Update()
    {
        var step = Time.deltaTime * moveSpeed;
        if(Vector3.Distance(transform.position, destination.position) >= 0.01f){
            transform.position = Vector3.MoveTowards(transform.position, destination.position, step);
        }
    }
}
