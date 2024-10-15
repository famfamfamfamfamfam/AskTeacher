using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class GreenCarControl : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Debug.Log( speed + " " + turnSpeed);
    }
    [SerializeField]
    [Range(100, 500)]
    float speed;
    [SerializeField]
    [Range(100, 250)]
    float turnSpeed;
    float turn, move;

    // Update is called once per frame
    void Update()
    {
        turn = Input.GetAxis("Horizontal");
        move = Input.GetAxis("Vertical");
        rb.AddTorque(transform.up * turn * turnSpeed);
        rb.AddForce(transform.forward * speed * move);
    }
    //void FixedUpdate()
    //{
    //    Debug.Log(turn + " " + move);
    //    rb.AddTorque(transform.up * turn * turnSpeed);
    //    rb.AddForce(transform.forward * speed * move);
    //}
}
