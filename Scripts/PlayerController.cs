using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private string orientation = "NULL";

    public GameObject shot;
    public Transform shotSpawn;

    public float fireRate = 0.5f;
    public float nextFire = 0.0f;

    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
        }
    }


    void FixedUpdate()
    {
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 20.0f;
        var y = Input.GetAxis("Vertical") * Time.deltaTime * 20.0f;

        //NOTE: Actual character rotation is: transform.Rotate(Vector.up / down / left / right * 90)


        //if (Input.GetAxis("Horizontal") > 0 && orientation != "right")
        //{
        //    transform.Rotate(Vector2.right * 90);
        //    orientation = "right";
        //}
        //else if (Input.GetAxis("Horizontal") < 0 && orientation != "left")
        //{
        //    //change to left sprite
        //    orientation = "left";
        //}

        //if (Input.GetAxis("Vertical") > 0 && orientation != "up")
        //{
        //    //change to forward sprite
        //    orientation = "up";
        //}
        //else if (Input.GetAxis("Vertical") < 0 && orientation != "down")
        //{
        //    //change to backward sprite
        //    orientation = "down";
        //}

        //IF implementing true rotation, translate will need to reference
        //character orientation, not spacial orientation (as currently)
        //LEARN how spacial orientation affects movement (test by setting orientation in start
        //might need to move translations into conditionals above

        transform.Translate(x, 0, 0);
        transform.Translate(0, y, 0);
    }
}
