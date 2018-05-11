using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public GameObject enemy1;
    public GameObject enemy2;

    //need 16
    public GameObject top_center;
    public GameObject top_left;
    public GameObject top_right;
    public GameObject top_right_corner;
    public GameObject top_left_corner;

    public GameObject upper_left;
    public GameObject middle_left;
    public GameObject lower_left;

    public GameObject upper_right;
    public GameObject middle_right;
    public GameObject lower_right;

    public GameObject bottom_center;
    public GameObject bottom_left;
    public GameObject bottom_right;
    public GameObject bottom_left_corner;
    public GameObject bottom_right_corner;

    void Start ()
    {
        Screen.SetResolution(1280, 720, true);

        StartCoroutine(SpawnSystem());
    }

    IEnumerator SpawnSystem()
    {
        
        yield return new WaitForSeconds(3.0f);

        Instantiate(enemy1, top_left.transform.position, top_left.transform.rotation);
        Instantiate(enemy1, bottom_right.transform.position, bottom_right.transform.rotation);

        yield return new WaitForSeconds(5.0f);

        Instantiate(enemy1, upper_left.transform.position, upper_left.transform.rotation);
        Instantiate(enemy1, lower_right.transform.position, lower_right.transform.rotation);

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
