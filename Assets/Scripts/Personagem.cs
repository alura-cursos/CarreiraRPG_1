using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personagem : MonoBehaviour {
    private Animator controleAnimacao;
    private float velocidade = 0.2f;
	private void Start () {
        this.controleAnimacao = this.GetComponent<Animator>();
	}
	
	
	private void Update () {
        Vector3 direcao = new Vector3();
        direcao.y = Input.GetAxis("Vertical");
        direcao.x = Input.GetAxis("Horizontal");

        this.transform.position += direcao * this.velocidade;
        bool estouAndando = direcao.magnitude != 0;
        this.controleAnimacao.SetBool("EstaAndando", estouAndando);
        this.controleAnimacao.SetFloat("VelocidadeX", direcao.x);
        this.controleAnimacao.SetFloat("VelocidadeY", direcao.y);
    }
}
