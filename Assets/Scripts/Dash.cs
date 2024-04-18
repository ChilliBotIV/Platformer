using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dash : MonoBehaviour
{
    PlayerMovement1 moveScript;

    public float DashTime;
    public float DashSpeed;
    // Start is called before the first frame update
    void Start()
    {
       moveScript = GetComponent<PlayerMovement1>();

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            StartCoroutine(MyDash());
        }
    }

    IEnumerator MyDash()
    {
        float startTime = Time.time;

        while(Time.time < startTime + DashTime)
        {
            transform.Translate(Vector3.forward * DashSpeed);
        
            yield return null;
        }
    }
}
