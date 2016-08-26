using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ControleTexto : MonoBehaviour {

	public GameObject chave;
	public GameObject fala;
	public GameObject fala2;
	bool estaNoLoop = false;
	Text txt;

	// Use this for initialization
	void Start () {
		txt = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown(KeyCode.Alpha1))
		{
			if (!estaNoLoop)
			{
				fala2.SetActive(false);
				chave.SetActive(true);
				Destroy(gameObject);
			}
		}
		else if (Input.GetKeyDown(KeyCode.Alpha2))
		{
			txt.text = "";
			fala2.SetActive(false);
			StartCoroutine(Falar());
		}
	}

	IEnumerator Falar()
	{
		if (!estaNoLoop)
		{
			estaNoLoop = true;
			yield return new WaitForSeconds(0.5f);
			fala.SetActive(true);
			yield return new WaitForSeconds(5);
			fala.SetActive(false);
			yield return new WaitForSeconds(5);
			fala2.SetActive(true);

			estaNoLoop = false;
		}
	}
}
