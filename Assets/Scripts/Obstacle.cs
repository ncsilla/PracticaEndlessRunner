using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    // Start is called before the first frame update
    PlayerController playerController;
    void Start()
    {
       playerController = GameObject.FindObjectOfType<PlayerController>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "MobileMaleFree1")
            playerController.Die();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
