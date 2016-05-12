using UnityEngine;
using System.Collections;

public class SphereCommands : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
    void MakeColorBlue()
    {
        this.gameObject.GetComponent<Renderer>().material.color = Color.blue;
    }

    void MakeColorRed()
    {
        this.gameObject.GetComponent<Renderer>().material.color = Color.red;
    }

    void Reset()
    {
        this.gameObject.GetComponent<Renderer>().material.color = Color.yellow;
    }
}
