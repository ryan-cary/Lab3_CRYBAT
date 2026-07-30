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
        // -- Point to Camera --
        // Thanks Justin!!
        Vector3 mouseToWorld = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 directionToMouse = Vector3.Normalize(mouseToWorld - transform.position);
        transform.LookAt(Vector3.forward, directionToMouse);

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
