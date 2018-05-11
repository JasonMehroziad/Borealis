using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTrishot : MonoBehaviour
{

    public int health;

    public float speed;
    public GameObject bullet;

    public float fireRate;
    public float nextFire = 0.0f;

    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = GetComponent<Rigidbody2D>().transform.up * speed;
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
    
            Instantiate(bullet, shotSpawn.position + shotSpawn.up, shotSpawn.rotation); //center

            shotSpawn.Rotate(Vector3.forward * -45);
            Instantiate(bullet, shotSpawn.position + shotSpawn.up, shotSpawn.rotation); //right

            shotSpawn.Rotate(Vector3.forward * 90);
            Instantiate(bullet, shotSpawn.position + shotSpawn.up, shotSpawn.rotation); //left

            shotSpawn.Rotate(Vector3.forward * -45);
            nextFire = Time.time + fireRate;


        }

        if (health < 1 /*|| transform.position.x > 20.0 || transform.position.x < -25.0 
            || transform.position.y > 20.0 || transform.position.y < -15.0)*/)
        {
            Destroy(gameObject);
        }
    }
}
