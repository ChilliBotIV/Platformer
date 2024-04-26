using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter()
    {
        FindObjectOfType<GameManager>();
        GameManager gameManager = FindObjectOfType<GameManager>();
        gameManager.PickedUp();
        Destroy(gameObject);
    }
}
