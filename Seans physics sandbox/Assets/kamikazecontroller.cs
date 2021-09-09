using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kamikazecontroller : MonoBehaviour
{
    public ParticleSystem engineparticle;



    Rigidbody2D rb;
    public float movespeed;
    public float rotatespeed;
    // Start is called before the first frame update
    void Start()
    {
      rb = GetComponent<Rigidbody2D>();
      
      
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W)){
          rb.AddRelativeForce(Vector2.up*movespeed * Time.deltaTime);
            if(engineparticle.isPlaying == false)
            {
                engineparticle.Play();
            }

        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            engineparticle.Stop();
        }


        if(Input.GetKey(KeyCode.D)){
          transform.Rotate(0,0,-rotatespeed* Time.deltaTime,Space.World);
        }
         if(Input.GetKey(KeyCode.A)){
          transform.Rotate(0,0,rotatespeed* Time.deltaTime,Space.World);
        }

    }
}
