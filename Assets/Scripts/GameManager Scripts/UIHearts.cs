using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIHearts : MonoBehaviour
{


    //public GameObject heart;
    public GameObject heart1, heart2, heart3, heart4;

    private GameManager manager;
   // private List<Image> hearts = new List<Image>();
    PlayerHealth playerHealth;
    private PlayerHealth Health;

    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<GameManager>();
        manager = GetComponent<GameManager>();
        Health =  GetComponent<PlayerHealth>();


        heart1.gameObject.SetActive(true);
        heart2.gameObject.SetActive(true);
        heart3.gameObject.SetActive(true);
        heart4.gameObject.SetActive(true);



        //     playerHealth = PlayerHealth.instance;
        //    //playerHealth.DamageTaken += UpdateHearts;
        //    //playerHealth.HealthUpgraded += AddHearts;   
        //     for (int i = 0;i<playerHealth.maxHealth; i++){
        //         GameObject h = Instantiate(heart, this.transform);
        //         hearts.Add(h.GetComponent<Image>());
        //     }
    }

    // void UpdateHearts()
    // {
    //     Debug.Log("update hearts has run");
    //     int heartFill = playerHealth.Health;
    //     foreach (Image i in hearts){
    //         i.fillAmount = heartFill;
    //         heartFill -= 1;
    //     }

    // }

    // void AddHearts(){
    //     foreach (Image i in hearts){
    //         Destroy(i.gameObject);
    //     }
    //     hearts.Clear();
    //     for (int i = 0;i<playerHealth.maxHealth; i++){
    //         GameObject h = Instantiate(heart, this.transform);
    //         hearts.Add(h.GetComponent<Image>());
    //     }


    // }

    void update()
    {
        // switch (playerHealth)
        // {
        //     case 4:
        //     heart1.gameObject.SetActive(true);
        //     heart2.gameObject.SetActive(true);
        //     heart3.gameObject.SetActive(true);
        //     heart4.gameObject.SetActive(true);
        //     break;

        //     case 3:
        //     heart1.gameObject.SetActive(true);
        //     heart2.gameObject.SetActive(true);
        //     heart3.gameObject.SetActive(true);
        //     heart4.gameObject.SetActive(false);
        //     break;
        // }


        if (playerHealth.health == 3)
        {
            heart1.gameObject.SetActive(true);
            heart2.gameObject.SetActive(true);
            heart3.gameObject.SetActive(true);
            heart4.gameObject.SetActive(false);
        }
    }
}
