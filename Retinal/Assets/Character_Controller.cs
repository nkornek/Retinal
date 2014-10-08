using UnityEngine;
using System.Collections;

public class Character_Controller : MonoBehaviour {
	public EyeballScript eyeball;
	public Transform eyeballTransform;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton(0))
		{
			eyeball.FireBall();
		}

		if (!eyeball.attached & Vector3.Distance(transform.position, eyeballTransform.position) < 2)
		{
			print ("test");
			if (Input.GetMouseButton(1))
			{
				eyeball.PickUp();
			}
		}
	
	}
}
