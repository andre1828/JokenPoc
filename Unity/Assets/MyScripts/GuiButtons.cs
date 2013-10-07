using UnityEngine;
using System.Collections;

public class GuiButtons : MonoBehaviour {
	
	private int _countTimes;
	
	// Use this for initialization
	void Start () {
		_countTimes = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if(_countTimes == 3)
			Application.LoadLevel("MenuScene");
	}
	
	void OnGUI(){
		
		try {
			
			if(GUI.Button(new Rect (Screen.width - 100,0,100,50), "Espiao"))
			{
				_countTimes += 1;
				Debug.Log("Fire button");
				MovePlayers();
				SelecionaLutador(Lutador.Espiao);
				
			}
			
			if(GUI.Button(new Rect (Screen.width - 100,50,100,50), "Guerreiro"))
			{
				_countTimes += 1;
				Debug.Log("Fire button");
				MovePlayers();
				SelecionaLutador(Lutador.Tropa);
			}
			
			if(GUI.Button(new Rect (Screen.width - 100,100,100,50), "Tank"))
			{
				_countTimes += 1;
				Debug.Log("Fire button");
				MovePlayers();
				SelecionaLutador(Lutador.Tank);
			}
			
		} catch (System.Exception ex) {
			Debug.Log(ex.Message);	
			//Evitar para por ex...
		}
		
		
	}
	
	private void MovePlayers()
	{
		GameObject.Find("P1").GetComponent<MoveToCenter>().enabled = true;
		GameObject.Find("E1").GetComponent<MoveToCenter>().enabled = true;
	}
	
	private void SelecionaLutador(Lutador classe)
	{
		GameObject.Find("P1").GetComponent<Attack>().Classe = classe;
		GameObject.Find("P1").GetComponent<Attack>().enabled = true;
		GameObject.Find("E1").GetComponent<Attack>().Classe = GetEnemy().Value;
		GameObject.Find("E1").GetComponent<Attack>().enabled = true;
		
	}
	
	private Lutador? GetEnemy()
	{
		switch (Random.Range(0,10) % 3) 
		{
			case 0:
				Debug.Log("Enemy: " + Lutador.Espiao);
				return Lutador.Espiao;
			case 1:
				Debug.Log("Enemy: " + Lutador.Tropa);
				return Lutador.Tropa;
			case 2:
				Debug.Log("Enemy: " + Lutador.Tank);
				return Lutador.Tank;
			default:
				return null;
		}
	}
}
