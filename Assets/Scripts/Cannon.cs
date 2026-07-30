using System;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    [SerializeField] private Cannonball ball_prefab;
    [SerializeField] private float baseFirePower;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Initialized");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Fire();
        }
    }

    void Fire()
    {
        Debug.Log("Firing the cannon!!");
    }
}
