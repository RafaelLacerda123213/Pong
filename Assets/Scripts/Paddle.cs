using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField]
    float velocidade = 0.5f;
    [SerializeField]
    KeyCode upKey = KeyCode.UpArrow;

    [SerializeField]
    KeyCode downKey= KeyCode.DownArrow;



    // Update is called once per frame
    void Update()
    {
        // seta para cima premida, entao subir, senao se tecla para baixo primida, entao descer//
        
        if(Input.GetKey(upKey))
        {
            transform.position =
                transform.position + velocidade * Vector3.up * Time.deltaTime;

            //transform.position += velocidade * Vector3.up * Time.deltaTime;

        } else if (Input.GetKey(downKey))
        {
            transform.position = 
                transform.position + velocidade * Vector3.down * Time.deltaTime;

        }

        float cameraHeight = Camera.main.orthographicSize;
        //var para ir buscar o size da camera
        float haflPaddleSize = 0.5f;
        // ajuda a definir o limte para o paddle

        if (transform.position.y >= cameraHeight - haflPaddleSize)
        {
            // na prática o codigo a baixo faz, transform.position.y = 3f - 0.5f
            // como nao posso fazer diretamente usei um var auxiliar
            
            Vector3 positionAux = transform.position;
            positionAux.y = cameraHeight - haflPaddleSize;
            transform.position = positionAux;
        }
        if (transform.position.y <= -cameraHeight + haflPaddleSize)
        {
            Vector3 positionAux = transform.position;
            positionAux.y = -cameraHeight + haflPaddleSize;
            transform.position = positionAux;
        }
            

    }
}

// outra forma de fazer o codigo a usar um clamp( uma função matematica, limitar a um intervalo, um valor so pode estar num intervalor
// que eu dou, clamp pode ser limitar a um determinado intervalo) CLAMP: 

// Vector3 positionAux = transform.position
// positionAux.y = Mathf.Clamp(transform.position.y,
//                 -cameraHeight + halfPaddleSize,
//                  cameraHeight - halfPaddleSize);
//  transform.position = positionAux;
