using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JogoCarta : MonoBehaviour
{
    string[] carta = new string[] { " o Ás", " o Rei", " a Dama", " o Valete", " o Dois", " o Três", " o Quatro", " o Cinco", " o Seis", " o Sete", " o Oito", " o Nove", " o Dez" };
    string[] naipe = new string[] { " de Copas", " de Paus", " de Ouros", " de Espadas"};
    string cartaescolhida;



    // Start is called before the first frame update
    void Start()
    {

        Iniciar();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            CriarCarta();
        }
            
    }

    void Iniciar() // mensagem incial
    {

        Debug.Log("Olá vamos jogar um jogo!");
        Debug.Log("Clica no espaço para teres uma carta");  

    }

    void CriarCarta() //formação da carta
    {
        cartaescolhida = carta[Random.Range(0, carta.Length)] + naipe[Random.Range(0, naipe.Length)];
        Debug.Log("Saiu" + cartaescolhida);
    

    }

        
}
