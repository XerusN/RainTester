using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;


public class UIDataMode : MonoBehaviour
{

    

    public GameObject linePrefab;

    public GameObject moreLessButons;
    public GameObject moreButton;
    public GameObject lessButton;
    public GameObject menu;

    private Vector3 lineIniPos = new Vector3(0, 110, 0);
    private float lineOffset = 40f;
    private int lineCountMax = 5;

    private int lineCount = 1;
    private Vector3 linePos;

    public List<GameObject> lines = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        lines.Add(Instantiate(linePrefab));
        lines[0].transform.parent = menu.transform;
        lines[0].transform.position = lineIniPos;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoreLine()
    {
        if (lineCount >= lineCountMax)
        {
            return;
        }

        linePos = lineIniPos + lineOffset * Vector3.down * lineCount;
        lines.Add(Instantiate(linePrefab, linePos, linePrefab.transform.rotation));
        lineCount++;

        if (lineCount >= lineCountMax)
        {
            moreButton.SetActive(false);
        }

        if (lineCount > 1)
        {
            lessButton.SetActive(true);
        }

        moreLessButons.transform.position += lineOffset * Vector3.down;
    }

    public void LessLine()
    {
        if (lineCount <= 1)
        {
            return;
        }

        lineCount = lineCount-1;
        Debug.Log(lineCount);
        Destroy(lines[lineCount]);
        
        if (lineCount < lineCountMax)
        {
            moreButton.SetActive(true);
        }

        if (lineCount <= 1)
        {
            lessButton.SetActive(false);
        }

        moreLessButons.transform.position += lineOffset * Vector3.up;
    }
}
