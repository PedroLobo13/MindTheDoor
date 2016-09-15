using UnityEngine;
using System.Collections;

public class ControladorGeral : MonoBehaviour {

	public static ControladorGeral controlador = null;

	public ObjetosControlador [] objetos;

	public static bool mostrarCursor = false;

	void Awake()
	{
		if (controlador == null)
		{
			controlador = this;
		}
		else
		{
			Destroy(gameObject);
		}

		DontDestroyOnLoad(gameObject);
	}

	// Use this for initialization
	void Start () 
	{
		StartCoroutine(ControladorGameobjects());
	}

	void Update()
	{
		Cursor.visible = mostrarCursor;
	}

	IEnumerator ControladorGameobjects()
	{
		foreach (ObjetosControlador obj in objetos)
		{
			if (obj.gameobject != null)
			{
				switch (obj.tipos)
				{
					case ObjetosControlador.tipo.LigarEDestruirTempo:
						yield return new WaitForSeconds(obj.tempoInstanciar);
						obj.gameobject.SetActive(true);
						yield return new WaitForSeconds(obj.tempoDestruir);
						Destroy(obj.gameobject);
					break;

					case ObjetosControlador.tipo.Ligar:
						yield return new WaitForSeconds(obj.tempoInstanciar);
						obj.gameobject.SetActive(true);
					break;

					case ObjetosControlador.tipo.Instanciar:
						yield return new WaitForSeconds(obj.tempoInstanciar);
						Instantiate(obj.gameobject);
					break;

					case ObjetosControlador.tipo.Destruir:
						yield return new WaitForSeconds(obj.tempoDestruir);
						Destroy(obj.gameobject);
					break;

					case ObjetosControlador.tipo.InstanciarEDestruirTempo:
						yield return new WaitForSeconds(obj.tempoInstanciar);
						Instantiate(obj.gameobject);
						yield return new WaitForSeconds(obj.tempoDestruir);
						Destroy(obj.gameobject);
					break;

					case ObjetosControlador.tipo.InstanciarEDestruirColisao:

					break;
				}
			}
		}
	}

}
