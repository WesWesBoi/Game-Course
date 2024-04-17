using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ItemCollect : MonoBehaviour
{
    public int coins = 0;

    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            coins++;
            Debug.Log("coins:" + coins);
        }



            if (other.gameObject.tag ==  "Player" && coins == 4)
        {
            SceneManager.LoadScene("SceneTwo");

        }
        
        
    }
}