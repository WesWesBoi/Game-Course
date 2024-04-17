using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    private Rigidbody rb;

    [SerializeField] float x;
    [SerializeField] float y= 9.03f;
    [SerializeField] float z; 
    [SerializeField] float frequency;
    [SerializeField] float amplitude;

    // Start is called before the first frame update
    void Start()
    {
        // Gets the RigidBody2D component
        rb = GetComponent<Rigidbody>();
        frequency = 1f;
        amplitude = 3f;
        transform.position = new Vector3(x, -1.82f, z);
        z = 3;

    }

    // Update is called once per frame
    void Update()
    {
        x = Mathf.Cos(Time.time * frequency) * amplitude;
        y = 7;
        x = 4;
        z = Mathf.Sin(Time.time * frequency) * amplitude;
        transform.position = new Vector3(x, y, z+2.5f); 
        
      
    }


}
