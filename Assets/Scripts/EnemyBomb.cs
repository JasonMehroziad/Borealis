using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBomb : MonoBehaviour
{

    public int health;

    public float speed;
    public GameObject shot;

    public float timer;

    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, speed); //for testing ONLY; in game velocity set by spawner
        timer += Time.time;
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
        if (Time.time > timer)
        {
            Transform shotSpawn = gameObject.transform;
            for (int i = 0; i < 8; i++)
            {
                Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
                shotSpawn.Rotate(Vector3.forward * 45);
            }
            Destroy(gameObject);
        }

        if (health == 0)
        {
            Destroy(gameObject);
        }
    }
}
