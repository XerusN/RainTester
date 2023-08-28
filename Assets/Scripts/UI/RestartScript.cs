using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RestartScript : MonoBehaviour
{

    private Button button;

    // Start is called before the first frame update
    void Start()
    {
        this.button = GetComponent<Button>();
        if (button == null)
        {
            Debug.LogError("Cannot Find button");
        }
        this.button.onClick.AddListener(RestartGame);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void RestartGame()
    {
        SceneManager.LoadScene(0);
    }

}
