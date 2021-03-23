using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bola : MonoBehaviour
{
    [SerializeField]
    float velocidade = 5f;

    bool bolaFoiLancada = false;

    [SerializeField]
    float tempoDeEspera = 2f;

    float tempoDecorrido = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (bolaFoiLancada == false)
        {

            tempoDecorrido += Time.deltaTime;

            if(tempoDecorrido >= tempoDeEspera)
            {
              GetComponent<Rigidbody2D>().velocity = velocidade * Random.onUnitSphere;
                bolaFoiLancada = true;
            }
         
        }
        
    }



}




