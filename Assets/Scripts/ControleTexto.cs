using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ControleTexto : MonoBehaviour {

	public GameObject item;
	public GameObject falaRepetida;
	public GameObject falaDecisao;
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
				falaDecisao.SetActive(false);
				item.SetActive(true);
				Destroy(gameObject);
			}
		}
		else if (Input.GetKeyDown(KeyCode.Alpha2))
		{
			txt.text = "";
			falaDecisao.SetActive(false);
			StartCoroutine(Falar());
		}
	}

	IEnumerator Falar()
	{
		if (!estaNoLoop)
		{
			estaNoLoop = true;
			yield return new WaitForSeconds(0.5f);
			falaRepetida.SetActive(true);
			yield return new WaitForSeconds(5);
			falaRepetida.SetActive(false);
			yield return new WaitForSeconds(5);
			falaDecisao.SetActive(true);

			estaNoLoop = false;
		}
	}
}
