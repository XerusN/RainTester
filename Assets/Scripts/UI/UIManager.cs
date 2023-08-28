using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{

    public TextMeshProUGUI dripNbInterface;
    public TextMeshProUGUI endText;
    public TMP_Dropdown playerSelection;
    private GameManager gameManagerScript;

    public GameObject menu;
    public GameObject gameUI;
    public GameObject endUI;

    private string dripNbInterfaceText = "Nb of drips = ";

    private int prefabIndex;


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
        if (gameManagerScript.gameIsActive && !gameManagerScript.gameEnd)
        {
            dripNbInterface.text = dripNbInterfaceText + gameManagerScript.dripOnPlayer;
        }
    }

    public int GetPrefabIndex()
    {
        prefabIndex = playerSelection.value;
        return prefabIndex;
    }

    public void GameUI()
    {
        menu.SetActive(false);
        gameUI.SetActive(true);
    }

    public void EndUI()
    {
        gameUI.SetActive(false);
        endUI.SetActive(true);
        endText.text = dripNbInterfaceText + gameManagerScript.dripOnPlayer;
    }
}
