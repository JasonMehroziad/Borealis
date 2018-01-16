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

        //GOES IN GAME CONTROLLER
        //if(direction == "Left")        
        //{
        //    GetComponent<Rigidbody2D>().transform.Rotate(Vector3.forward * 90);
        //}

        //if (direction == "Right")
        //{
        //    GetComponent<Rigidbody2D>().transform.Rotate(Vector3.forward * -90);
        //}

        GetComponent<Rigidbody2D>().velocity = GetComponent<Rigidbody2D>().transform.up;// * speed;
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

        if(health == 0)
        {
            Destroy(gameObject);
        }
    }
}
