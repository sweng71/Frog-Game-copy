using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour
{   
    [HideInInspector]
    public float speed;
    private Rigidbody2D myBody;
    void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate() 
    {
        myBody.velocity = new Vector2(speed, myBody.velocity.y); // Do not want to change y velocity
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}