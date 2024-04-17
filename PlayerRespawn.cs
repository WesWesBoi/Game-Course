using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{


    float positionX;
    float positionY;
    float positionZ;
    // Start is called before the first frame update
    void Start()
    {
        positionX = 3.8f;
        positionY = 7.01f;
        positionZ = -15.9f;
        transform.position = new Vector3(positionX, positionY, positionZ);
    }

    // Update is called once per frame
    void Update()
    {

    }



}

