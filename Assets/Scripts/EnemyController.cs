using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    public int health;
    public float speed;
    public string direction;

    public GameObject shot;
    public float fireRate;
    public float nextFire = 0.0f;

	void Start () {
        GetComponent<Rigidbody2D>().velocity = GetComponent<Rigidbody2D>().transform.up * speed;
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Shot")
        {
            health--;
        }
    }
	
	void Update () {
        if (Time.time > nextFire)
        {
            Instantiate(shot, gameObject.transform.position + Vector3.down, gameObject.transform.rotation);
            nextFire = Time.time + fireRate;
        }

        if (health < 1 || transform.position.x > 20.0 || transform.position.x < -25.0
            || transform.position.y > 20.0 || transform.position.y < -15.0)
        {
            Destroy(gameObject);
        }
    }
}
