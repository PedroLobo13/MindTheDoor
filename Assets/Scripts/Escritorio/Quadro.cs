using UnityEngine;
using System.Collections;

public class Quadro : MonoBehaviour {

	public GameObject texturaDasParedes;
	public GameObject paredesComEmissao;
	MeshRenderer materialDasParedes;
	public Texture emissivo;
	public GameObject luzQuadro;
	public GameObject chaveEmissiva;
	public GameObject luzesAzuis;

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
		texturaDasParedes.SetActive(!texturaDasParedes.activeSelf);
		paredesComEmissao.SetActive(!paredesComEmissao.activeSelf);
		luzQuadro.SetActive(!luzQuadro.activeSelf);
		chaveEmissiva.SetActive(!chaveEmissiva.activeSelf);
		luzesAzuis.SetActive(!luzesAzuis.activeSelf);
	}
}
