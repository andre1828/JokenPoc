using UnityEngine;
using System.Collections;

public class SetEspiao : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if(Input.GetMouseButton(0))
		GameObject.Find("P1").GetComponent<Attack>().Classe = Lutador.Tropa;
	}
}
