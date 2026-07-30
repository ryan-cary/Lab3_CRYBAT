using System;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    [SerializeField] private Cannonball _ball_prefab;
    [SerializeField] private float _baseFirePower = 15;

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

        Cannonball liveBall = Instantiate(_ball_prefab, transform.position, transform.rotation);
        liveBall.GetComponent<Rigidbody2D>().AddForce((transform.rotation * Vector3.up) * _baseFirePower, ForceMode2D.Impulse);
    }
}
