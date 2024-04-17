using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBullet : MonoBehaviour
{
    

    public GameObject myBullet;
    public GameObject newBullet;
    public GameObject myPlayer;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {

            float playerX = myPlayer.transform.position.x;
            float playerY = myPlayer.transform.position.y;
            float playerZ = myPlayer.transform.position.z+2f;

            newBullet = Instantiate(myBullet, new Vector3(playerX, playerY, playerZ), Quaternion.identity);



        }

        Destroy(newBullet, 2f);

    }

}
