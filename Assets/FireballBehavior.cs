using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballBehavior : MonoBehaviour
{
    public float shootingSpeed;
    private float fireballXValue;
    private float fireballYValue;
    // Start is called before the first frame update
    void Start()
    {
        fireballXValue = gameObject.transform.position.x;
        fireballYValue = gameObject.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        fireballXValue += shootingSpeed*Time.deltaTime;
        gameObject.transform.position = new Vector3(fireballXValue, fireballYValue);

        if (fireballXValue > 10) {
            Destroy(gameObject);
        }
    }
}
