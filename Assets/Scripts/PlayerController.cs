using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float playerSpeed = 1.4f; //  5 km/h
    private Vector3 posIni = new Vector3(-2, 1, 0);
    private float xLimit = 102f;

    // Start is called before the first frame update
    void Start()
    {
        this.transform.position = posIni;
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.x < xLimit)
        {
            this.transform.Translate(Time.deltaTime * playerSpeed * Vector3.right);
        }
    }
}