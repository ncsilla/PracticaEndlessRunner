using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    public GameObject[] tilePrefabs;
    public float zSpawn = 0;
    public float tileLength = 30;
    public Transform playerTransform;

    // Start is called before the first frame update
    void Start()
    {
        SpawnTile(0);   
    }

    // Update is called once per frame
    void Update()
    {
        if (playerTransform.position.z > zSpawn)
        {
            Debug.Log(playerTransform.position.z);
            SpawnTile(0);
        }
    }

    public void SpawnTile(int tileIndex)
    {
        Instantiate(tilePrefabs[tileIndex], transform.forward * zSpawn, transform.rotation);
        zSpawn += tileLength;
    }
}
