using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    // Start is called before the first frame update
    PlayerController playerController;
    void Start()
    {
       playerController = GameObject.FindObjectOfType<PlayerController>();
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
        {
            playerController.AddCoin();
            Debug.Log("Added coin");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
