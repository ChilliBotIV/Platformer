using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePlayer : MonoBehaviour
{

    public int damage;
    float cooldown;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void Update(){
        cooldown -= Time.deltaTime;
    }

//    public void OnTriggerEnter(){
//        Health health = GetComponent<PlayerHealth>();
//        if (cooldown <= 0){
//            if (health != null){
//                health.TakeDamage(damage);
//            }
//            cooldown = 1f;
//        }
//    }
        
}
