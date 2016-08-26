using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public LayerMask layer;
	public bool coletouChave = false;
	RaycastHit hit;
	Transform cameraFilha;

	// Use this for initialization
	void Start () 
	{
		cameraFilha = transform.GetChild(0);
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown(KeyCode.Mouse0))
		{
			if (Physics.Raycast(cameraFilha.transform.position, cameraFilha.transform.forward, out hit, 1.5f, layer))
			{
				
				hit.transform.gameObject.SendMessage("Acao");
				
			}
		}

		Debug.DrawRay(cameraFilha.transform.position,cameraFilha.transform.forward);
	}

}
