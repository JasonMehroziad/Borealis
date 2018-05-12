using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Peek : MonoBehaviour
{

    public int health;

    public float speed;
    public GameObject bullet;

    public float fireRate;
    public float nextFire = 0.0f;

    public float peekTime;
    private float startTime = 0.0f;
    private bool peeking = false;

    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = GetComponent<Rigidbody2D>().transform.up * speed;
        startTime = Time.time;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Shot")
        {
            health--;
        }
    }

    void Update()
    {
        if (Time.time > nextFire)
        {
            Transform shotSpawn = gameObject.transform;

            Instantiate(bullet, shotSpawn.position + shotSpawn.up * 2, shotSpawn.rotation); //center

            shotSpawn.Rotate(Vector3.forward * -45);
            Instantiate(bullet, shotSpawn.position + shotSpawn.up * 2, shotSpawn.rotation); //right

            shotSpawn.Rotate(Vector3.forward * 90);
            Instantiate(bullet, shotSpawn.position + shotSpawn.up * 2, shotSpawn.rotation); //left

            shotSpawn.Rotate(Vector3.forward * -45);
            nextFire = Time.time + fireRate;
        }

        if (peeking && Time.time > startTime + peekTime)
        {
            GetComponent<Rigidbody2D>().velocity = transform.up * 2;
        }

        if (!peeking && transform.position.y < 10.0f)
        {
            peeking = true;
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            startTime = Time.time;
        }

        if (health < 1 /*|| transform.position.x > 20.0 || transform.position.x < -25.0 
            || transform.position.y > 20.0 || transform.position.y < -15.0)*/)
        {
            Destroy(gameObject);
        }
    }
}

