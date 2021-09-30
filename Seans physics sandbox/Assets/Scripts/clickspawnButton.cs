using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickspawnButton : MonoBehaviour
{
    public List<GameObject> spawnableObjects;
    public GameObject objectToSpawn;
    public bool spawncircles;
    public float spawntime;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("I happen only once");

        objectToSpawn = spawnableObjects[1];



    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("I always happen");   
        if(Input.GetMouseButtonDown(0)) {

            Spawnobject(objectToSpawn);


        }

        if (Input.GetMouseButtonUp(0))
        {

            spawncircles = false;
          
        }
 

       





    }
    public void Changeobjecttospawn(int objectnumber)
    {

        objectToSpawn = spawnableObjects[objectnumber];



    }




    private IEnumerator SpawnCircle()
    {
        while (spawncircles)
        {
          
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
