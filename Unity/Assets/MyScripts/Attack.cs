using UnityEngine;
using System.Collections;

public class Attack : MonoBehaviour {
	
	public Lutador Classe;
	public GameObject Target;
	
	// Use this for initialization
	void Start () {
		Target.SendMessage("Defender", Classe);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	Lutador? Batalha(Lutador lutador1, Lutador lutador2)
	{
		Debug.Log("Palyer: " + lutador1 + "Enemy: " + lutador2);
		
		if(lutador1 == lutador2)
		{
			Debug.Log("Draw");
			return null;
		}
		else
		{
			if(lutador1 == Lutador.Espiao)
			{
				if(lutador2 == Lutador.Tank)
					return Lutador.Espiao;
				
				if(lutador2 == Lutador.Tropa)
					return Lutador.Tropa;
				
			}
			
			if(lutador1 == Lutador.Tank)
			{
				if(lutador2 == Lutador.Espiao)
					return Lutador.Espiao;
				
				if(lutador2 == Lutador.Tropa)
					return Lutador.Tank;
			}
			
			if(lutador1 == Lutador.Tropa)
			{
				if(lutador2 == Lutador.Espiao)
					return Lutador.Espiao;
				
				if(lutador2 == Lutador.Tank)
					return Lutador.Tank;
			}
		}
		
		return null;
	}
	
	void Defender(Lutador enemy){

		Lutador? vencedor = Batalha(Classe, enemy);
		if(vencedor.HasValue)
			Debug.Log("Vencedor: " + vencedor.Value);
		
		if(!vencedor.HasValue || vencedor.Value != Classe)
		{
			Debug.Log("Destroy");
			Destroy(gameObject, 1.9f);
			Debug.Log("Destroyed");
			
		}
		
		
		Debug.Log("Will change");
		StartCoroutine(MyLoadLevel(2.3f));
		Debug.Log("Changed");
	}
	
	IEnumerator MyLoadLevel(float delay)
	{
	    yield return new WaitForSeconds(delay);
		Debug.Log("Change level");
		Application.LoadLevel("GameScene");
	}
}

