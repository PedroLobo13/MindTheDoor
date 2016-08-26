using UnityEngine;
using System.Collections;

public class Chave : MonoBehaviour {

	public bool coletouChave = false;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	void Acao()
	{
		coletouChave = true;
		GetComponent<MeshRenderer>().enabled = false;
		GetComponent<BoxCollider>().enabled = false;
	}
}
