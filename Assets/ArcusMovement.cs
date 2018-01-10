using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcusMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody2D>().velocity = Vector2.up;
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<Rigidbody2D>().velocity += Vector2.up;
	}
}
