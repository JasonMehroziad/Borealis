using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    public int health;

    public float speed;
    public GameObject shot;

    public float fireRate;
    public float nextFire = 0.0f;

	void Start () {
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, speed);
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
            Instantiate(shot, gameObject.transform.position + Vector3.down + Vector3.left, gameObject.transform.rotation);
            Instantiate(shot, gameObject.transform.position + Vector3.down + Vector3.right, gameObject.transform.rotation);
            nextFire = Time.time + fireRate;
        }

        if(health == 0)
        {
            Destroy(gameObject);
        }
    }
}
