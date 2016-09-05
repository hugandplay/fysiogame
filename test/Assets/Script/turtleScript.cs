using UnityEngine;
using System.Collections;

public class turtleScript : MonoBehaviour 
{
	public float level = 0.5f;
	public bool sink = false;
	public GameObject Titanic;
	// Use this for initialization
	void Start () 
	{
		if(level < 0.5f)
		{
			sink = true;
			Destroy (Titanic);
		}
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(0.1f * Time.deltaTime, 0, 0);

		//chainsaw mothafucka
		transform.Rotate (0,0,30f);
	
	}
}
