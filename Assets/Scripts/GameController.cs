using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public GameObject enemy1;
    public GameObject enemy2;

    //need 16
    public GameObject top_center;
    //public GameObject top_left_diagonal;
    //public GameObject top_right_diagonal;
    public GameObject top_left;
    public GameObject bottom_right;
   

    void Start ()
    {
        Screen.SetResolution(1280, 720, true);

        StartCoroutine(SpawnSystem());
    }

    IEnumerator SpawnSystem()
    {
        yield return new WaitForSeconds(3.0f);

        Instantiate(enemy1, top_center.transform.position, top_center.transform.rotation);

        yield return new WaitForSeconds(5.0f);

        Instantiate(enemy1, top_left.transform.position, top_left.transform.rotation);
        Instantiate(enemy1, bottom_right.transform.position, top_center.transform.rotation);


        yield return new WaitForSeconds(5.0f);


        /*
        spawn.transform.Translate(Vector3.left * 5);
        Instantiate(enemy1, spawn.transform.position, spawn.transform.rotation);

        spawn.transform.Translate(Vector3.right * 10);
        Instantiate(enemy1, spawn.transform.position, spawn.transform.rotation);

        yield return new WaitForSeconds(5.0f);

        spawn.transform.Translate(Vector3.left * 5);
        Instantiate(enemy2, spawn.transform.position, spawn.transform.rotation);
        */

        //yield return new WaitForSIntaeconds(5.0f);

        //spawn.transform.Translate(Vector3.left * 20 + Vector3.down * 20);
        //spawn.transform.Rotate(Vector3.forward * -90);
        //Instantiate(enemy1, spawn.transform.position, spawn.transform.rotation);

        //spawn.transform.Translate(Vector3.right * 40);
        //spawn.transform.Rotate(Vector3.forward * 180); 
        //Instantiate(enemy1, spawn.transform.position, spawn.transform.rotation);

    }

}
