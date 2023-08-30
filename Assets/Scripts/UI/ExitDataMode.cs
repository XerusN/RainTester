using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ExitDataMode : MonoBehaviour
{

    private Button button;

    // Start is called before the first frame update
    void Start()
    {
        this.button = GetComponent<Button>();
        if (button == null)
        {
            Debug.LogError("Cannot Find Data Mode button");
        }

        this.button.onClick.AddListener(ExitMode);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ExitMode()
    {
        SceneManager.LoadScene(0);
    }
}
