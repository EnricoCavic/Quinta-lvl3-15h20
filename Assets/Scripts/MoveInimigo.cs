using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveInimigo : MonoBehaviour
{

    // declaração de variáveis
    // primeiro vem o tipo, dps vem o nome
    Animator meuAnimator;

    // Start is called before the first frame update
    void Start()
    {
        meuAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
