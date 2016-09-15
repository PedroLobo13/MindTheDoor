using UnityEngine;
using System.Collections;

public class Chave : MonoBehaviour {

	public bool coletouChave = false;

	[Tooltip("Não obrigatório. Coloque uma fala que seja habilitada ao coletar")]
	public GameObject falaAoColetar;

	void Acao()
	{
		coletouChave = true;
		GetComponent<MeshRenderer>().enabled = false;
		GetComponent<BoxCollider>().enabled = false;
		if (falaAoColetar != null)
		{
			StartCoroutine(habilitarFala());
		}
	}

	IEnumerator habilitarFala()
	{
		falaAoColetar.SetActive(true);
		yield return new WaitForSeconds(10f);
		falaAoColetar.SetActive(false);

	}
}
