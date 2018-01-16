using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject spawn;

    void Start ()
    {
        StartCoroutine(SpawnSystem());
    }

    IEnumerator SpawnSystem()
    {
        yield return new WaitForSeconds(3.0f);

        spawn.transform.Translate(Vector3.left * 5);
        Instantiate(enemy1, spawn.transform.position, spawn.transform.rotation);

        spawn.transform.Translate(Vector3.right * 10);
        Instantiate(enemy1, spawn.transform.position, spawn.transform.rotation);

        yield return new WaitForSeconds(5.0f);

        spawn.transform.Translate(Vector3.left * 5);
        Instantiate(enemy2, spawn.transform.position, spawn.transform.rotation);

        //yield return new WaitForSeconds(5.0f);

        //spawn.transform.Translate(Vector3.left * 20 + Vector3.down * 20);
        //spawn.transform.Rotate(Vector3.forward * -90);
        //Instantiate(enemy1, spawn.transform.position, spawn.transform.rotation);

        //spawn.transform.Translate(Vector3.right * 40);
        //spawn.transform.Rotate(Vector3.forward * 180); 
        //Instantiate(enemy1, spawn.transform.position, spawn.transform.rotation);

    }

}
