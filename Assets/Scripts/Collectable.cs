using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    public AudioSource collectSound;

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
        collectSound.Play();
        Destroy(gameObject);
    }

}
