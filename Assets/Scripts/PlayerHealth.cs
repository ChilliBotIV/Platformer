using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerHealth : MonoBehaviour
{

    public static PlayerHealth instance;

    public event Action DamageTaken;
    public event Action HealthUpgraded;

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
        health = maxHealth;
    }

    // Update is called once per frame
    public void TakeDamage()
    {
        if(health <= 0){
            return;
        }
        health -= 1;
        if(DamageTaken != null){
            DamageTaken();
        }
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
        if(HealthUpgraded != null){
            HealthUpgraded();
        }
    }

}
