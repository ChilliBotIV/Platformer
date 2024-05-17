using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePlayer : MonoBehaviour
{
    private PlayerHealth Health;
    public int damage;
    float cooldown;
    // Start is called before the first frame update
    void Start()
    {
        Health = FindObjectOfType<PlayerHealth>();

    }

    public void Update(){
        cooldown -= Time.deltaTime;
    }

    public void OnTriggerEnter(){
        if (cooldown <= 0){
            if (Health != null){
                Health.TakeDamage();
            }
            cooldown = 1f;
        }
    }
        
}
