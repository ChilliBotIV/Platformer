using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
[RequireComponent(typeof(GameManager))]

public class BoltCounter : MonoBehaviour
{
    public static BoltCounter Instance;

    private GameManager manager;

    public TMP_Text boltText;
    // Start is called before the first frame update

    void Awake(){
        Instance = this;
    }

    void Start()
    {
        manager = GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        boltText.text = "Bolts: " + manager.Collectables.ToString();

    }
}
