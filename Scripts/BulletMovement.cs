using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour {

    public float speed;

	void Start () {
        GetComponent<Rigidbody2D>().velocity = Vector3.up * speed;
	}

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Enemy")
            Destroy(other.gameObject);

        Destroy(gameObject);
    }
}
