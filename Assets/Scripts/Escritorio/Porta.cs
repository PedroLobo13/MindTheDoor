using UnityEngine;
using System.Collections;

public class Porta : MonoBehaviour {

	public GameObject chave, portaEsq, portaDir;
	Chave c;
	bool jaEntrou = false;

	// Use this for initialization
	void Start () 
	{
		c = chave.GetComponent<Chave>();
		//Physics.IgnoreCollision(GetComponent<Collider>(), GetComponent<Collider>());
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.CompareTag("Player"))
		{
			if (c.coletouChave)
			{
			 	if(!jaEntrou)
			 	{
					StartCoroutine(AbrirPorta());
				}
			}
		}
	}

	IEnumerator AbrirPorta()
	{ 	
		jaEntrou = true;
		GetComponent<BoxCollider>().enabled = false;
		for (int p = 0; p < 120; p++)
		{
			portaDir.transform.eulerAngles = new Vector3(0, p, 0);
			portaEsq.transform.eulerAngles = new Vector3(0, -p, 0);
			yield return new WaitForSeconds(0.01f);
		}
		Destroy(gameObject);
	}
}
