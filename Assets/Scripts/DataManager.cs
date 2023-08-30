using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class DataManager : MonoBehaviour
{

    public class testType
    {
        public int prefabIndex;
        public float playerSpeed;
        public int dripPerFrame;
        public int nbTest;
    }

    [System.Serializable]
    class SaveData
    {
        public int[,,,] tab;    //[prefabIndex, playerSpeed, dripPerFrame, testIndex]
    }

    public int[,,,] tab;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Save()
    {
        SaveData data = new SaveData();
        data.tab = this.tab;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.dataPath, json);
    }
}
