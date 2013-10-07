using UnityEngine;
using System.Collections;

public class MoveToCenter : MonoBehaviour {
	public Vector3 endPoint;
	private float speed = 5.0f;
	
	// Use this for initialization
	void Start () {	
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position.x != endPoint.x)
		transform.position = Vector3.MoveTowards(transform.position, endPoint, speed * Time.deltaTime);
	}
	
		

}
