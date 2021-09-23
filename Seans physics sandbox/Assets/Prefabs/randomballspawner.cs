using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomballspawner : MonoBehaviour
{
    public GameObject ballSpawn;
    public float timeSpawner;






    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Spawnball");  
    }
    IEnumerator Spawnball()
    {
        while (true)
        {
            Spawnobject(ballSpawn);
            yield return new WaitForSeconds(timeSpawner);

        }

    }

    void Spawnobject(GameObject objecttospawn)
    {
        Vector2 theposition = new Vector2(transform.position.x + Random.Range(-60, 58), transform.position.y);
        Instantiate(objecttospawn, theposition, Quaternion.identity);
    }



}
