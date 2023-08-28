using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DripBehaviour : MonoBehaviour
{

    private float dripSpeed = 5.0f;
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
        this.transform.Translate(Time.deltaTime * dripSpeed * Vector3.down);
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(this.gameObject);
        if (other.gameObject.CompareTag("Player"))
        {
            gameManagerScript.dripOnPlayer += 1;
        }
    }
}
