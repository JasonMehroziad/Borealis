using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour {

    public float speed; 
    public string target;

    private float xMin = -15f;
    private float xMax = 15f;
    private float yMin = -10f;
    private float yMax = 10f;

    void Start ()
    {
        GetComponent<Rigidbody2D>().velocity = GetComponent<Rigidbody2D>().transform.up * speed;
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == target)
        {
            Destroy(gameObject);
        }
    }

    void Update()
    {
        if (gameObject.transform.position.x < xMin || gameObject.transform.position.x > xMax 
            || gameObject.transform.position.y < yMin || gameObject.transform.position.y > yMax)
        {
            Destroy(gameObject);
        }
    }
}
