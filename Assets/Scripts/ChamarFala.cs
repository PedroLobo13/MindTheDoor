using UnityEngine;
using System.Collections;

public class ChamarFala : MonoBehaviour {

	public int numeroDaFala;
	public float esperaParaRodar = 0;
	public GameObject controladorFalas;

	// Use this for initialization
	void Start () 
	{
		
		//controladorFalas = GameObject.Find("Controlador de Falas");
	}


	void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			StartCoroutine(EsperarERodarFala());
		}

	}

	IEnumerator EsperarERodarFala()
	{
		yield return new WaitForSeconds(esperaParaRodar);
		controladorFalas.SendMessage("RodarFala", numeroDaFala-1);
		Destroy(this);
	}
}
