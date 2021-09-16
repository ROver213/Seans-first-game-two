using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickspawn : MonoBehaviour
{

    public GameObject circle;
    public GameObject dudeonthemoon;
    public GameObject flinger;
    public GameObject square;
    public GameObject squarestill;
    public bool spawncircles;
    public float spawntime;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("I happen only once");       
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("I always happen");   
        if(Input.GetMouseButtonDown(0)) {

            spawncircles = true;
            StartCoroutine("SpawnCircle");
        }

        if (Input.GetMouseButtonUp(0))
        {

            spawncircles = false;
          
        }


        if (Input.GetMouseButtonDown(3))
        {

            Spawnobject(square);
        }

        if (Input.GetMouseButtonDown(1))
        {

            Spawnobject(dudeonthemoon);
        }

        if (Input.GetMouseButtonDown(4))
        {

            Spawnobject(squarestill);
        }

        if (Input.GetMouseButtonDown(2))
        {

            Spawnobject(flinger);
        }

    }

    private IEnumerator SpawnCircle()
    {
        while (spawncircles)
        {
            Spawnobject(circle);
            yield return new WaitForSeconds(spawntime);
        }


    }










        void Spawnobject (GameObject objecttospawn){
            Debug.Log("I have been summoned");
            Vector2 clickposition =new Vector2(Input.mousePosition.x,Input.mousePosition.y);
            Vector2 worldposition = Camera.main.ScreenToWorldPoint(clickposition);
            Instantiate(objecttospawn,worldposition,Quaternion.identity);
        }
}
