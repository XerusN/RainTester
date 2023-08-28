using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public int dripOnPlayer = 0;
    public bool gameIsActive = false;
    public bool gameEnd = false;
    public GameObject[] playerPrefabs;

    private Vector3 spawnPos;
    public float playerSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame(float speed, int prefabIndex)
    {
        playerSpeed = speed;
        if (playerPrefabs.Length > prefabIndex)
        {
            this.GetComponent<UIManager>().GameUI();
            gameIsActive = true;
            spawnPos = playerPrefabs[prefabIndex].transform.position;
            StartCoroutine(WaitBeforeSpawn(prefabIndex));
        }
        
    }

    IEnumerator WaitBeforeSpawn(int prefabIndex)
    {
        yield return new WaitForSeconds(5);
        Instantiate(playerPrefabs[prefabIndex], spawnPos, playerPrefabs[prefabIndex].transform.rotation);
    }

    public void EndGame()
    {
        gameEnd = true;
        this.GetComponent<UIManager>().EndUI();
    }
}
