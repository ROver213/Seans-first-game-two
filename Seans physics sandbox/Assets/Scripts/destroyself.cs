using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyself : MonoBehaviour
{
    public float doomsday;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject,doomsday);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
