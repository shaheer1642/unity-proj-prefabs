using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
    public Rigidbody2D character;
    public GameObject fireball;
    public float movementSpeed;
    
    void Start()
    {
        // use this function to initialize
        // anything
    }
    
    // Update is called once per frame
    void Update()
    {
        character.velocity = new Vector2(Input.GetAxis("Horizontal")*movementSpeed, Input.GetAxis("Vertical")*movementSpeed);

        // When spacebar is hit
        if(Input.GetKeyDown(KeyCode.Space))
        {
            // instantiate the fireball object
            Instantiate(fireball,
                new Vector2(gameObject.transform.position.x + 2, gameObject.transform.position.y),
                new Quaternion(0, 0, 0, 0));

        }
    }
}
