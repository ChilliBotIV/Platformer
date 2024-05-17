using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePlayer : MonoBehaviour
{
    private PlayerHealth Health;
    public GameObject Player;
    public int damage;
    
    public int knockback = 250;
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
                Player.transform.position = new Vector3(0, 0, -knockback);
            }
            cooldown = 1f;
        }
    }
        
}
