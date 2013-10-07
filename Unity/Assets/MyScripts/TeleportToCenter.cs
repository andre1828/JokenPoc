using UnityEngine;
using System.Collections;

public class TeleporToCenter : MonoBehaviour {
	private Vector3 speed = new Vector3(3,0,0);
	
	// Use this for initialization
	void Start () {
	rigidbody.MovePosition( new Vector3(10,0,0) + speed * Time.deltaTime);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void FixedUpdated(){
		
		
	}
}
