using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Counter : MonoBehaviour
{
    public static Counter Instance;

    public TMP_Text boltText;
    // Start is called before the first frame update

    void Awake(){
        Instance = this;
    }

    void Start()
    {
        //Collectables collectables = GetComponent<Collectables>();
       //boltText.text = "Bolts: " + Collectables.ToString();
    }

    // Update is called once per frame
    void Update()
    {
    }
}
