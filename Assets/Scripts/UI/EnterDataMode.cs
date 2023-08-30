using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnterDataMode : MonoBehaviour
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

        this.button.onClick.AddListener(DataMode);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DataMode()
    {
        SceneManager.LoadScene(1);
    }
}
