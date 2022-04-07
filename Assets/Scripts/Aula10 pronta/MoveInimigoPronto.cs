using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveInimigoPronto : MonoBehaviour
{


    Animator meuAnimator;
    Rigidbody meuRb;

    Transform transformAlvo; 
    float distanciaAtual; 
    bool podeSeguir;

    public float distanciaDeVisao;
    public float velocidade;

    void Start()
    {
        meuAnimator = GetComponent<Animator>();
        meuRb = GetComponent<Rigidbody>();

        transformAlvo = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        distanciaAtual = Vector3.Distance(transform.position, transformAlvo.position);
        podeSeguir = distanciaAtual < distanciaDeVisao;

        meuAnimator.SetBool("Pode Seguir", podeSeguir);
    }

    void FixedUpdate() 
    {
        if(podeSeguir)
        {
            transform.LookAt(transformAlvo);

            // direção entre duas posições = final - inicial
            Vector3 dir = transformAlvo.position - transform.position;
            meuRb.AddForce( dir.normalized * velocidade , ForceMode.Force );
        }       
    }
}
