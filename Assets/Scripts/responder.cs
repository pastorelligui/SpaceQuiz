using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class responder : MonoBehaviour {

	public int idTema;

	public Text pergunta;
	public Text respostaA;
	public Text respostaB;
	public Text respostaC;
	public Text respostaD;
	public Text infoRespostas;

	public string[] perguntas; // armazena as perguntas
	public string[] alternativaA; // armazena as alternativas A
	public string[] alternativaB; // armazena as alternativas B
	public string[] alternativaC; // armazena as alternativas C
	public string[] alternativaD; // armazena as alternativas D
	public string[] corretas; // armazena as alternativas corretas

	private int idPergunta;

	private float acertos;
	private float questoes;
	private float media;


	// Use this for initialization
	void Start () {
		idPergunta = 0;
		questoes = perguntas.Length; //saber o numero de questoes que terá no quiz

		pergunta.text = perguntas[idPergunta];
		respostaA.text = alternativaA [idPergunta];
		respostaB.text = alternativaB [idPergunta];
		respostaC.text = alternativaC [idPergunta];
		respostaD.text = alternativaD [idPergunta];


		infoRespostas.text = "Respondendo " + (idPergunta + 1).ToString()+ " de " + questoes.ToString ()+" perguntas.";
	}
	
	public void resposta(string alternativa) //TESTA A ALTERNATIVA CORRETA
	{
		if (alternativa == "A") {
		//EXECUTA O COMANDO PARA RESPOSTA A
			if (alternativaA [idPergunta] == corretas [idPergunta]) {
				acertos += 1;
			}
		}  

		else if (alternativa == "B") {
		//EXECUTA O COMANDO PARA RESPOSTA B
			if (alternativaB [idPergunta] == corretas [idPergunta]) {
				acertos += 1;
			}
		}

		if (alternativa == "C") {
		//EXECUTA O COMANDO PARA RESPOSTA C
			if (alternativaC [idPergunta] == corretas [idPergunta]) {
				acertos += 1;
			}
		}

		if (alternativa == "D") {
		//EXECUTA O COMANDO PARA RESPOSTA D
			if (alternativaD [idPergunta] == corretas [idPergunta]) {
				acertos += 1;
			}
		}

		proximaPergunta ();

	}


	void proximaPergunta(){
		idPergunta += 1; //avança mais um, ou seja para a próxima pergunta

		if (idPergunta <= (questoes - 1)) {

			pergunta.text = perguntas [idPergunta];
			respostaA.text = alternativaA [idPergunta];
			respostaB.text = alternativaB [idPergunta];
			respostaC.text = alternativaC [idPergunta];
			respostaD.text = alternativaD [idPergunta];


			infoRespostas.text = "Respondendo " + (idPergunta + 1).ToString () + " de " + questoes.ToString () + " perguntas.";
		} 
		else
		{
			// O que fazer quando terminar as perguntas

			Application.LoadLevel ("notaFinal");
		}
			
	}	

}
