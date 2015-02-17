using UnityEngine;

using System.Collections;

public class movement : MonoBehaviour{
	
	public Vector3 target;
	public float speed=10f;
	Vector3 screenPos;
	int direction = 1;
	
	void  Start (){
		target = Random.insideUnitSphere * 5;
		transform.Rotate(target);
	}
	void  FixedUpdate (){
		rigidbody.MovePosition(rigidbody.position + (transform.forward * speed * Time.deltaTime * direction));
	}
	void OnCollisionEnter (Collision coll){
		if (coll.gameObject.tag == "collectable"){                 
			if (screenPos.x < Screen.width / 2){
				direction *= -1;
			}
		}
	}
}