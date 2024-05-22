using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.AI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int Collectables = 0;
    public int ShipParts = 0;
    public int CurrentCheckpoint = 0;



[ContextMenu("Save")]
    public void SaveGame(){
        string path = Path.Combine(Application.persistentDataPath, "save.json");
        StreamWriter wrtier = new StreamWriter(path);
        SaveData newSavedData = new SaveData();
        newSavedData.Collectables = Collectables;
        newSavedData.CurrentCheckpoint = CurrentCheckpoint;
        JsonUtility.ToJson(newSavedData);
        wrtier.Write(JsonUtility.ToJson(newSavedData));
        wrtier.Close();

    }

    //public void LoadGame(){
        //string path = Path.Combine(Application.persistentDataPath , "save.json");
        //string path = "/home/tom/data/save.json";
        //StreamReader reader = new StreamReader(path);
        //reader.ReadToEnd();
        //JsonUtility.FromJson<SaveData>(reader.ReadToEnd());
        

    //}
    public void PickedUp() {
        Collectables++;
    }

    public void Shipped(){
        ShipParts++;
    }

    //Health
    public void DamageTaken(){
    
    }

    public void HealthUpgraded(){

    }

    public void ReachedCheckpoint(int checkpoint) {
        if (checkpoint > CurrentCheckpoint){
            CurrentCheckpoint = checkpoint;
        }
            
    }
    // Start is called before the first frame update
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
    static void OnGameStart()
    {
       GameObject prefab = (GameObject)Resources.Load( "Game Manager");
       GameObject instance = GameObject.Instantiate(prefab);
       DontDestroyOnLoad(instance);
    }
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
