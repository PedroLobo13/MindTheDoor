using UnityEngine;
using System.Collections;

public class Portais : MonoBehaviour 
{
	public GameObject portalParaAtivar;
	public GameObject [] portaisParaEsconder;


	void Acao()
	{
		portalParaAtivar.SetActive(true);
		foreach(GameObject p in portaisParaEsconder)
		{
			p.SetActive(false);
		}
		Debug.Log("Trocou portal para " + gameObject.name);
	}

}
