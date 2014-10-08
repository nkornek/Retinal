using UnityEngine;
using System.Collections;

public class EyeballScript : MonoBehaviour {
	public bool attached;
	public Transform parentTransform;

	// Use this for initialization
	void Start () {
		attached = true;
	
	}
	
	// Update is called once per frame
	void Update () {

		if (attached)
		{
			transform.position = parentTransform.position;
			transform.rotation = parentTransform.rotation;
		}
	
	}

	public void FireBall()
	{
		if (attached)
		{
			attached = false;
			transform.parent = null;
			rigidbody.AddRelativeForce(Vector3.forward * 500);
			rigidbody.AddRelativeForce(Vector3.up * 250);
		}
	}

	public void PickUp()
	{
		attached = true;
		transform.parent = parentTransform;
	}
}
