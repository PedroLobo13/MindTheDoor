using UnityEngine;
using System.Collections;

public class Portais : MonoBehaviour 
{
	public GameObject [] portais;
	private int portalAtual = 0;
	private bool jaEscondeu = true;
	

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown(KeyCode.T))
		{
			jaEscondeu = false;
			if (portalAtual < portais.Length - 1)
			{
				portalAtual +=1;
				jaEscondeu = false;
			}
			else
			{
				portalAtual = 0;
				jaEscondeu = false;
			}

		}

		if (!jaEscondeu)
		{
			foreach (GameObject element in portais)
			{
				element.SetActive(false);
			}

			portais[portalAtual].SetActive(true);

			jaEscondeu = true;
		}

	}

}
