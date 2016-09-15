using UnityEngine;
using System.Collections;

[System.Serializable]
public class ObjetosControlador : System.Object {

	[Tooltip("Gameobject a ser manipulado.")]
	public GameObject gameobject;
	[Tooltip("Tempo para instanciar o objeto em segundos.")]
	public float tempoInstanciar;
	[Tooltip("Tempo para destruir o objeto em segundos (Obs: se for do tipo Instanciar e Destruir, será contado após o instanciamento.")]
	public float tempoDestruir;
	[Tooltip("Gameobject que ao ser tocado, manipulará o Gameobject manipulado.")]
	public GameObject gameobjectDeColisao;
	public enum tipo {LigarEDestruirTempo, Ligar, InstanciarEDestruirTempo, InstanciarEDestruirColisao, Destruir, Instanciar};
	[Tooltip("Tipo da manipulação.")]
	public tipo tipos;
}
