using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ShipPart : MonoBehaviour
{
    public AudioSource collected;
    public GameObject LevelComplete;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter()
    {
        FindObjectOfType<GameManager>();
        GameManager gameManager = FindObjectOfType<GameManager>();
        gameManager.Shipped();
        collected.Play();
        Destroy(gameObject);
        LevelComplete.SetActive(true);
        Time.timeScale = 0f;
        Cursor.lockState = CursorLockMode.None;


    }
}
