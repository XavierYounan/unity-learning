using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : MonoBehaviour
{
    public Transform sphere;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Calculate the directoon
        //direction = destination - source (vector)
        Vector3 directionToFace = sphere.position - transform.position;
        Debug.DrawRay(transform.position, directionToFace, Color.red);
        //face towards direction
        Quaternion targetRotation = Quaternion.LookRotation(directionToFace);

        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime);
    }
}
