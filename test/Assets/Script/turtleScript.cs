using UnityEngine;
using System.Collections;

public class turtleScript : MonoBehaviour {
	// Use this for initialization
	void Start () {
        transform.Translate(2, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(0.1f * Time.deltaTime, 0, 0);

		//chainsaw mothafucka
		transform.Rotate (0,0,30f);
	
	}
}
