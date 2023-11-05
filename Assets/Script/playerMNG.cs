using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMNG : MonoBehaviour
{
    float h;
    float v;
    float speed = 15f;

    Vector3 move;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        h = Input.GetAxisRaw("Horizontal");
        v = Input.GetAxisRaw("Vertical");

        move = new Vector3(h, 0, v).normalized;

        transform.position += move* speed*Time.deltaTime;
    }
}
