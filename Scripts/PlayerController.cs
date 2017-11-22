using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private string orientation = "NULL";

    public GameObject shot;
    public float moveSpeed = 50.0f;

    public float xMin;
    public float xMax;
    public float yMin;
    public float yMax;

    public float fireRate;
    public float nextFire = 0.0f;

    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(shot, gameObject.transform.position + Vector3.up + Vector3.left, gameObject.transform.rotation);
            Instantiate(shot, gameObject.transform.position + Vector3.up + Vector3.right, gameObject.transform.rotation);
        }
    }


    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal"); 
        float y = Input.GetAxis("Vertical"); 
        Vector2 moveDirection = new Vector2(x, y);
        GetComponent<Rigidbody2D>().velocity = moveDirection * moveSpeed;

        GetComponent<Rigidbody2D>().position = new Vector2(Mathf.Clamp(GetComponent<Rigidbody2D>().transform.position.x, xMin, xMax),
            Mathf.Clamp(GetComponent<Rigidbody2D>().transform.position.y, yMin, yMax));

        //transform.Translate(x, 0, 0);
        //transform.Translate(0, y, 0);
    }
}
