using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public float moveSpeed = 8f;
	public CollectableManager  collectableManager;
	public Vector3 jumpVector;
	// Use this for initialization
	void Start () {
	
	}
	void FixedUpdate () 
	{
		float x = Input.GetAxis ("Horizontal");
		float y = Input.GetAxis ("Vertical");

		Vector3 pos = new Vector3 (x * moveSpeed, 0f, y * moveSpeed);
		rigidbody.AddForce (pos);

		if (Input.GetKeyDown(KeyCode.Space)) 
		{
			rigidbody.AddForce(jumpVector, ForceMode.Force);
		}
	}
	void OnTriggerEnter(Collider other)
	{
		if(other.transform.tag == "Collectable")
			collectableManager.Addcollectable();
		Destroy (other.gameObject);
	}
}
