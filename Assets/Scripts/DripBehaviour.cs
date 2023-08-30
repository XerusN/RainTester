using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DripBehaviour : MonoBehaviour
{

    private float dripSpeed = 5.0f;
    private GameManager gameManagerScript;
    private DataModeManager dataModeManager;

    private Boolean dataMode = false;

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
        this.transform.Translate(Time.deltaTime * dripSpeed * Vector3.down);
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(this.gameObject);
        if (other.gameObject.CompareTag("Player"))
        {
            if (!dataMode)
            {
                gameManagerScript.dripOnPlayer += 1;
            }
            else
            {
                //gameManagerScript.dripOnPlayer += 1;
            }
        }
    }
}
