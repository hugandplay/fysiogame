using UnityEngine;
using System.Collections;

public class haasScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(1.1f * Time.deltaTime, 0, 0);
	}
}
