using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerspeed = 1;
    [SerializeField] float movespeed = 0.01f;
    [SerializeField] float slowspeed = 0.004f;
    [SerializeField] float boostspeed = 0.05f;
    void Start()
    {

    }

    void Update()
    {
        float steerAmmount = Input.GetAxis("Horizontal") * steerspeed * Time.deltaTime;
        float speedAmmount = Input.GetAxis("Vertical") * movespeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmmount);
        transform.Translate(0, speedAmmount, 0);
        
    }

     void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag != "booster")
        {
            return;
        }
        movespeed = boostspeed;
    }
}
