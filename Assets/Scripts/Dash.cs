using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dash : MonoBehaviour
{
    PlayerMovement1 moveScript;

    public float cooldown = 1f;
[Range(0.2f, 1)]
    public float DashTime;
    [Range(100, 300)]
    public float DashSpeed;
    // Start is called before the first frame update
    void Start()
    {
       moveScript = GetComponent<PlayerMovement1>();

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && Time.timeScale != 0f)
        {
            StartCoroutine(MyDash());
        }
    }

    IEnumerator MyDash()
    {
        float startTime = Time.time;

        while(Time.time < startTime + DashTime)
        {
            if (Time.timeScale != 0f){
                transform.Translate(Vector3.forward * DashSpeed * Time.deltaTime);

            }
        
            yield return null;

        }
    }
}
