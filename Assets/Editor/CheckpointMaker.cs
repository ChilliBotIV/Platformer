using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CheckpointMaker : MonoBehaviour
{
    [MenuItem("Checkpoints/New Checkpoint")]
    private static void NewMenuOption(){
        GameObject prefab =  (GameObject) Resources.Load("Checkpoint");
        Instantiate(prefab);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
