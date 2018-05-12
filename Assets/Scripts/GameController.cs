using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
    //enemy types
    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;
    public GameObject enemy4;
    public GameObject enemy5;

    //16 spawn points
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
        //Frame1
        yield return new WaitForSeconds(3.0f);

        //Frame2
        Instantiate(enemy1, top_left.transform.position, top_left.transform.rotation);
        Instantiate(enemy1, bottom_right.transform.position, bottom_right.transform.rotation);
        yield return new WaitForSeconds(25.0f);

        //Frame3
        Instantiate(enemy1, upper_left.transform.position, upper_left.transform.rotation);
        Instantiate(enemy1, lower_right.transform.position, lower_right.transform.rotation);
        yield return new WaitForSeconds(25.0f);

        //Frame4
        Instantiate(enemy4, bottom_left.transform.position, bottom_left.transform.rotation);
        Instantiate(enemy4, top_right.transform.position, top_right.transform.rotation);
        yield return new WaitForSeconds(5.0f);
        Instantiate(enemy4, middle_left.transform.position, middle_left.transform.rotation);
        Instantiate(enemy4, bottom_right_corner.transform.position, bottom_right_corner.transform.rotation);
        yield return new WaitForSeconds(5.0f);
        Instantiate(enemy4, top_center.transform.position, top_center.transform.rotation);
        yield return new WaitForSeconds(5.0f);

        //Frame5/6
        Instantiate(enemy3, top_center.transform.position, top_center.transform.rotation);
        yield return new WaitForSeconds(5.0f);
        Instantiate(enemy4, upper_left.transform.position, upper_left.transform.rotation);
        yield return new WaitForSeconds(5.0f);
        Instantiate(enemy4, middle_right.transform.position, middle_right.transform.rotation);
        yield return new WaitForSeconds(5.0f);
        Instantiate(enemy4, lower_left.transform.position, lower_left.transform.rotation);
        yield return new WaitForSeconds(20.0f);

        //Frame7
        Instantiate(enemy2, top_left.transform.position, top_left.transform.rotation);
        Instantiate(enemy2, top_right.transform.position, top_right.transform.rotation);
        Instantiate(enemy2, upper_left.transform.position, upper_left.transform.rotation);
        yield return new WaitForSeconds(10.0f); 

    }

}
