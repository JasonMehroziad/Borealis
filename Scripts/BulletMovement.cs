using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour {

    public float speed;
    public float xMin;
    public float xMax;
    public float yMin;
    public float yMax;
    public string target;

    void Start ()
    {
        GetComponent<Rigidbody2D>().velocity = Vector3.up * speed;
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
