using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kamikazecontroller : MonoBehaviour
{
    public ParticleSystem engineparticle;



    Rigidbody2D rb;
    public float movespeed;
    public float rotatespeed;
    public GameObject particles;
    public GameObject particleposition;
    public bool particleplaying = false;





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
            if(particleplaying == false)
            {
                GameObject myparticles = Instantiate(particles, particleposition.transform.position, Quaternion.identity);
                myparticles.transform.parent = particleposition.transform;
                particleplaying = true;

            }

        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            particleplaying = false;
            foreach(Transform child in particleposition.transform)
            {
                child.GetComponent<ParticleSystem>().Stop();
            }
        }


        if(Input.GetKey(KeyCode.D)){
          transform.Rotate(0,0,-rotatespeed* Time.deltaTime,Space.World);
        }
         if(Input.GetKey(KeyCode.A)){
          transform.Rotate(0,0,rotatespeed* Time.deltaTime,Space.World);
        }

    }
}
