using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickspawn : MonoBehaviour
{

    public GameObject circle;
  

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
            Debug.Log(Input.mousePosition.x);
            Spawnobject();
        } 
    }

        void Spawnobject (){
            Debug.Log("I have been summoned");
            Vector2 clickposition =new Vector2(Input.mousePosition.x,Input.mousePosition.y);
            Vector2 worldposition = Camera.main.ScreenToWorldPoint(clickposition);
            Instantiate(circle,worldposition,Quaternion.identity);
        }
}
