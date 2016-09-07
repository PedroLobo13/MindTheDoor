using UnityEngine;
using System.Collections;

public class ControladorPiano : MonoBehaviour {

	public GameObject player;
	public GameObject cameraPiano;
	private int qntTeclasAcertadas = 0;
	
	// Update is called once per frame
	void Update () 
	{
		if (cameraPiano.activeSelf)
		{
			if (Input.GetKeyDown(KeyCode.Escape))
			{
				Sair();
			}
		}
	
	}

	void Acao()
	{
		player.SetActive(false);
		cameraPiano.SetActive(true);
	}

	void Sair()
	{
		player.SetActive(true);
		cameraPiano.SetActive(false);
	}

	void ApertouTecla(string nota)
	{
		switch (qntTeclasAcertadas)
		{
			case 0:
			case 4:
			case 6:
			case 10:
				if (nota == "mi")
				{
					qntTeclasAcertadas += 1;
				}
				else
				{
					qntTeclasAcertadas = 0;
				}
				break;
			case 1:
			case 3:
			case 7:
			case 9:
				if (nota == "fa")
				{
					qntTeclasAcertadas += 1;
				}
				else
				{
					qntTeclasAcertadas = 0;
				}
				break;
			case 2:
			case 5:
			case 8:
				if (nota == "la")
				{
					qntTeclasAcertadas += 1;
				}
				else
				{
					qntTeclasAcertadas = 0;
				}
				break;
			case 11:
				if (nota == "la")
				{
					StartCoroutine(TerminarPuzzle());
				}
				else
				{
					qntTeclasAcertadas = 0;
				}
				break;
		}
	}

	IEnumerator TerminarPuzzle()
	{
		yield return new WaitForSeconds(1.5f);
		Debug.Log("Parabéns!");
		Sair();
		gameObject.SetActive(false);
	}
}
