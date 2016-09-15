using UnityEngine;
using System.Collections;

public class ControladorFalas : MonoBehaviour {

	public GameObject [] textosEFalas;
	private float tempoDaFala = 0;
	public int falaAtual;


	void RodarFala(int fala)
	{
		falaAtual = fala;
		StartCoroutine(AtivarEDesativarFala());
	}

	IEnumerator AtivarEDesativarFala()
	{
		foreach(GameObject fala in textosEFalas)
		{
			if (fala != null)
			{
				if (fala.activeSelf)
				{
					fala.SetActive(false);
				}
			}
		}
		tempoDaFala = textosEFalas[falaAtual].GetComponent<AudioSource>().clip.length + 1;
		textosEFalas[falaAtual].SetActive(true);
		yield return new WaitForSeconds(tempoDaFala);
		textosEFalas[falaAtual].SetActive(false);
	}
}
