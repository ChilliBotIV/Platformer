using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoints : MonoBehaviour
{

    public int checkpoint = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter()
    {
        FindObjectOfType<GameManager>();
        GameManager gameManager = FindObjectOfType<GameManager>();
        gameManager.ReachedCheckpoint(checkpoint);


    }
}
