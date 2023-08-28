using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private float xLimit = 102f;

    public Camera mainCamera;
    //private Vector3 cameraOffset = new Vector3(-10, 5, 0);
    private Vector3 cameraOffset = new Vector3(-2, 5, -10);

    private GameManager gameManagerScript;
    

    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
        gameManagerScript = GameObject.FindWithTag("GameController").GetComponent<GameManager>();
        if (gameManagerScript == null)
        {
            Debug.LogError("Cannot Find Game Manager Script");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.x < xLimit && gameManagerScript.gameIsActive)
        {
            this.transform.Translate(Time.deltaTime * gameManagerScript.playerSpeed * Vector3.right);
            mainCamera.transform.position = this.transform.position + cameraOffset;
        } else if (this.transform.position.x > xLimit)
        {
            gameManagerScript.EndGame();
            mainCamera.transform.Rotate(90 * Vector3.down);
            Destroy(this.gameObject);
        }
    }
}