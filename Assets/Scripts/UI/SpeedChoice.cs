using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedChoice : MonoBehaviour
{

    private GameManager gameManagerScript;
    private UIManager uiManager;
    private Button button;

    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        this.button = GetComponent<Button>();
        if (button == null)
        {
            Debug.LogError("Cannot Find button");
        }

        gameManagerScript = GameObject.Find("Game Manager").GetComponent<GameManager>();
        if (gameManagerScript == null)
        {
            Debug.LogError("Cannot Find Game Manager Script");
        }

        uiManager = GameObject.Find("Game Manager").GetComponent<UIManager>();
        if (uiManager == null)
        {
            Debug.LogError("Cannot Find UI Manager Script");
        }

        this.button.onClick.AddListener(SetSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetSpeed()
    {
        gameManagerScript.StartGame(speed, uiManager.GetPrefabIndex());
    }

}
