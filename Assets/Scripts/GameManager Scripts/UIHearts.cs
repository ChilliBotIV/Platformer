using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIHearts : MonoBehaviour
{

    public GameObject heart;
    private GameManager manager;
    private List<Image> hearts = new List<Image>();
    PlayerHealth playerHealth;
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<GameManager>();
        manager = GetComponent<GameManager>();
        

        playerHealth = PlayerHealth.instance;
       // playerHealth.DamageTaken += UpdateHearts;
       // playerHealth.HealthUpgraded += AddHearts;   
        for (int i = 0;i<playerHealth.maxHealth; i++){
            GameObject h = Instantiate(heart, this.transform);
            hearts.Add(h.GetComponent<Image>());
        }
    }

    void UpdateHearts()
    {
        Debug.Log("update hearts has run");
        int heartFill = playerHealth.Health;
        foreach (Image i in hearts){
            i.fillAmount = heartFill;
            heartFill -= 1;
        }

    }

    void AddHearts(){
        foreach (Image i in hearts){
            Destroy(i.gameObject);
        }
        hearts.Clear();
        for (int i = 0;i<playerHealth.maxHealth; i++){
            GameObject h = Instantiate(heart, this.transform);
            hearts.Add(h.GetComponent<Image>());
        }

        
    }
}
