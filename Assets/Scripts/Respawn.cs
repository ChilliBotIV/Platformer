using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public float threshold;
    public AudioSource drown;

    void FixedUpdate(){
        if(transform.position.y < threshold){
            transform.position = new Vector3(1, 2, 1);
            drown.Play();

        }
    }
}
