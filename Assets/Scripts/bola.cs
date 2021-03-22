using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bola : MonoBehaviour
{
    [SerializeField]
    float velocidade = 5f;
    float runTime = 2f;
    float pauseTime = 2f;

    bool paused = false;
    float currentRunTime = 0.0f;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(BolaMovimento());
    }

    // Update is called once per frame
    void Update()
    {

        
    }


    IEnumerator BolaMovimento()
    {
        yield return new WaitForSeconds(2f);
        GetComponent<Rigidbody2D>().velocity = velocidade * Random.insideUnitSphere;

    }


}


