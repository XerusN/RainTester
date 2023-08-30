using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
    private DataModeManager dataModeManager;

    private Boolean dataMode = false;
    private Boolean isSpawning = false;

    // Start is called before the first frame update
    void Start()
    {
        if (SceneManager.GetActiveScene().name == "MainScene")
        {
            this.dataMode = false;
            gameManagerScript = GameObject.FindWithTag("GameController").GetComponent<GameManager>();
            if (gameManagerScript == null)
            {
                Debug.LogError("Cannot Find Game Manager Script");
            }
        }
        else
        {
            this.dataMode = true;
            dataModeManager = GameObject.FindWithTag("GameController").GetComponent<DataModeManager>();
            if (dataModeManager == null)
            {
                Debug.LogError("Cannot Find Game Manager Script");
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!dataMode)
        {
            if (gameManagerScript.gameIsActive)
            {
                isSpawning = true;
            }
            else
            {
                isSpawning = false;
            }
        } else if (dataModeManager.testActive)
        {
            isSpawning = true;
        }
        else
        {
            isSpawning = false;
        }

        if (isSpawning)
        {
            for (int i = 0; i < dripNbPerFrame; i++)
            {
                xSpawnPos = UnityEngine.Random.Range(xLowLimit, xUpLimit);
                zSpawnPos = UnityEngine.Random.Range(zLowLimit, zUpLimit);
                ySpawnPos = UnityEngine.Random.Range(yLowLimit, yUpLimit);

                spawnPos = new Vector3(xSpawnPos, ySpawnPos, zSpawnPos);
                Instantiate(dripPrefab, spawnPos, dripPrefab.transform.rotation);
            }
        }
        
    }
        
}
