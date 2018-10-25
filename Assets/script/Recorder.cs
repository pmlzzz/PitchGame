using UnityEngine;
using System.Collections;

public class Recorder : MonoBehaviour {
    public float heightResult = 0;
    private float timer = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        heightResult = Random.Range(0, 11);
        //System.Console.WriteLine(heightResult);
	}
}
