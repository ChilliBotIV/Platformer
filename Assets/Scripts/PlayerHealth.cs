using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerHealth : MonoBehaviour
{

    public static PlayerHealth instance;

    
    private GameManager manager;

    public int maxHealth;
    public int health;
    public int Health{
        get { return health; }
    }
    void Awake()
    {
        if (instance == null){
            instance = this;
        }
    }

    private void Start()
    {
        FindObjectOfType<GameManager>();
        manager = GetComponent<GameManager>();
        health = maxHealth;
    }

    // Update is called once per frame
    [ContextMenu("takedamage")]
    public void TakeDamage()
    {
        if(health <= 0){
            return;
        }
        health -= 1;
       // if(DamageTaken != null){
       //     manager.DamageTaken();
       //     Debug.Log("damage has been taken");
       // }
    }

    public void Heal()
    {
        if(health >= maxHealth){
            return;
        }
        health += 1;
    }


    public void UpgradeHealth(){
        maxHealth++;
        health = maxHealth;
      //  if(HealthUpgraded != null){
      //      manager.HealthUpgraded();
      //  }
    }

}
