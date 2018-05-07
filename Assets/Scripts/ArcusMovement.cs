using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcusMovement : MonoBehaviour {

    public float startSpeed;
    public float accel;
    private float scale;

    private float yMin = -10f;
    private float yMax = 10f;

    void Start ()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.up * startSpeed;
        GetComponent<Rigidbody2D>().transform.Rotate(Vector3.forward * 180);
        scale = 1.0f;   
    }
	
	void Update ()
    {
        if (gameObject.transform.position.y < yMin || gameObject.transform.position.y > yMax)
        {
            Destroy(gameObject);
        }

        GetComponent<Rigidbody2D>().velocity *= scale;
        scale *= accel;
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Enemy" || other.tag == "EnemyShot")
        {
            Destroy(other.gameObject);
        }
    }
}       
