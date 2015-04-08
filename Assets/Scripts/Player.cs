using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	//velocidade de movimentaçao
	public float speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		float v = Input.GetAxis("Horizontal");
		float h = Input.GetAxis("Vertical");
		
		//pega a velocidade do rigidbody
		Vector3 vel = this.rigidbody.velocity;

		//muda a velocidade vertical
		vel.y = h * speed;
		vel.x = v * speed;
		
		
		//adiciona velocidade no player
		this.rigidbody.velocity = vel;

	
	}
}
