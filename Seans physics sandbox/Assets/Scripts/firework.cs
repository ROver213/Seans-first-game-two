using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firework : MonoBehaviour
{

    public Rigidbody2D rb;
    public float movespeed;
    public float rotatespeed;
    public GameObject explosion;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rotatespeed = Random.Range(-1000, 1000);
        




    }

    // Update is called once per frame
    void Update()
    {
        rb.AddRelativeForce(Vector2.up * movespeed * Time.deltaTime);
        rb.rotation += rotatespeed * Time.deltaTime;




    }

    private void OnDestroy()
    {
        Instantiate(explosion, transform.position, Quaternion.identity);
    }








}
