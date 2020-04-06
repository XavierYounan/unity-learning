using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] public Vector3 startPosition;
    [SerializeField] private float speed = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        // transform.position = new Vector3(0,0,0);
        transform.position = startPosition;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(horizontalInput,0,0) * (speed * Time.deltaTime));
    }
}
