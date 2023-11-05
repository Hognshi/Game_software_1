using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceSystem : MonoBehaviour
{
    public Transform dice;
    public bool isJumpping = false;

    private Rigidbody rb;
    private float speed = 5.1f; 
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        RollDice();
    }

    void RollDice()
    {
        if (!isJumpping)
        {
            if(Input.GetMouseButtonDown(0))
            {
                isJumpping = true;
                transform.rotation = Quaternion.identity;
                rb.AddForce(transform.up * 500);
                rb.AddTorque(Random.Range(0, 500), Random.Range(0, 500), Random.Range(0, 500));
                rb.velocity = Vector3.up *speed;
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Ground")
        {
            isJumpping = false;
        }
    }
}
