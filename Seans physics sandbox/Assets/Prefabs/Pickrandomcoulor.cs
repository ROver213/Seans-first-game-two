using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickrandomcoulor : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;


    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color =new Color(Random.Range(0f,1f),Random.Range(0f,1f),Random.Range(0f,1f),1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
