using UnityEngine;
using System.Collections;

public class Tecla : MonoBehaviour {

	public GameObject controladorPuzzle;
	private float controleMovimento = 0;
	public AudioSource audioSource;
	
	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown()
	{
		//Debug.Log(transform.parent.parent);
		controladorPuzzle.SendMessage("ApertouTecla", transform.parent.parent.name);
		StartCoroutine(Movimentar());
	}

	IEnumerator Movimentar()
	{
		while (controleMovimento < 5)
		{
			controleMovimento += 1;
			//transform.eulerAngles = new Vector3(controleMovimento, 0, 0);
			transform.Rotate(1,0,0);
			yield return new WaitForSeconds(0.01f);
		}
		audioSource.Play();
		while (controleMovimento > 0)
		{
			yield return new WaitForSeconds(0.01f);
			controleMovimento -= 1;
			//transform.eulerAngles = new Vector3(controleMovimento, 0, 0);
			transform.Rotate(-1,0,0);
		}

	}
}
