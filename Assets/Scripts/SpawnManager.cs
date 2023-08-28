using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject dripPrefab;

    private float dripNbPerFrame = 100f;

    private float xLowLimit = 0f;
    private float zLowLimit = -2f;
    private float yLowLimit = 15f;
    private float xUpLimit = 100f;
    private float zUpLimit = 2f;
    private float yUpLimit = 20f;

    private float xSpawnPos;
    private float zSpawnPos;
    private float ySpawnPos;
    private Vector3 spawnPos;

    private GameManager gameManagerScript;

    // Start is called before the first frame update
    void Start()
    {
        gameManagerScript = GameObject.FindWithTag("GameController").GetComponent<GameManager>();
        if (gameManagerScript == null)
        {
            Debug.LogError("Cannot Find Game Manager Script");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManagerScript.gameIsActive)
        {
            for (int i = 0; i < dripNbPerFrame; i++)
            {
                xSpawnPos = Random.Range(xLowLimit, xUpLimit);
                zSpawnPos = Random.Range(zLowLimit, zUpLimit);
                ySpawnPos = Random.Range(yLowLimit, yUpLimit);

                spawnPos = new Vector3(xSpawnPos, ySpawnPos, zSpawnPos);
                Instantiate(dripPrefab, spawnPos, dripPrefab.transform.rotation);
            }
        }
        
    }
        
}
