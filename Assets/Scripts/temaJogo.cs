using UnityEngine;
using UnityEngine.UI; 
using System.Collections;

public class temaJogo : MonoBehaviour {


	public Button btnPlay;
	public Text txtNomeTema;

	public GameObject infoTema;
	public Text txtInfoTema;
	public GameObject estrela1;
	public GameObject estrela2;
	public GameObject estrela3;

	public string[] nomeTema;
	public int numeroQuestoes;

	private int idTema;



	// Use this for initialization
	void Start () {
		idTema = 0;
		txtNomeTema.text = nomeTema [idTema];

		int notaFinal = 0;
		int acertos = 0;

		txtInfoTema.text = "Você acertou "+acertos.ToString()+ " de "+numeroQuestoes.ToString()+" questões!";
		infoTema.SetActive (false); //desliga a parte que tem as estrelas
		estrela1.SetActive (false); //desativa a estrela1
		estrela2.SetActive (false); //desativa a estrela2
		estrela3.SetActive (false); //desativa a estrela3
		btnPlay.interactable = false;
	}
	
	public void selecioneTema(int i) //função que irá ativar o botão que seleciona o tema, juntamente com seus componentes
	{
		idTema = i;
	    txtNomeTema.text = nomeTema [idTema];
		infoTema.SetActive(true); 
		btnPlay.interactable = true;
	}

	public void jogar() //habilita o botão Play para executar as perguntas
	{
		Application.LoadLevel ("T"+idTema.ToString());
	}

}
