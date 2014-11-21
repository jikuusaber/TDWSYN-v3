using UnityEngine;
using System.Collections;

public class CameraShake : MonoBehaviour {

	private GameObject world;

	// Use this for initialization
	void Start () 
	{
		world = GameObject.Find ("Word Ladder v1");

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "test") 
		{
			//iTween.MoveBy(world, iTween.Hash ("x", .5f , "easeType", "easeInOutExpo"));	
			//iTween.MoveBy(world, iTween.Hash ("x", -.5f , "easeType", "easeInOutExpo"));
			iTween.ShakePosition(world,iTween.Hash("x",5f,"time",1.0f));
		}


	}
}
