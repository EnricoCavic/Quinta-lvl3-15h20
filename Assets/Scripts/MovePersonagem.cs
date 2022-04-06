// bibliotecas / libs
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// aqui que começa nossa classe
public class MovePersonagem : MonoBehaviour
{
    // tipo e nome
    Animator meuAnimator;
    Rigidbody rb;

    public Vector2 vetorInput;
    public float velocidade = 30f;
    public float forca_de_giro = 20f;

    // ocorre uma vez ao iniciar o projeto
    void Start()
    {
        meuAnimator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        vetorInput = new Vector2();
    }

    // ocorre uma vez por frame
    void Update()
    {
        vetorInput.y = Input.GetAxis("Vertical");
        vetorInput.x = Input.GetAxis("Horizontal");

        // movimento
        float vel_final = vetorInput.y * velocidade;
        Vector3 frente_final = transform.forward * vel_final;
        rb.AddForce(frente_final, ForceMode.Force);

        // rotação
        float rot_final = vetorInput.x * forca_de_giro;
        Vector3 dir = transform.up * rot_final;
        rb.AddTorque(dir, ForceMode.Force);

        meuAnimator.SetFloat("Vertical", vetorInput.y);
    }
}
