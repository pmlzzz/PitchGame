using UnityEngine;
using System.Collections;

public class InputRecorder : MonoBehaviour {

	// Use this for initialization
	void Start () {
        this.GetComponent<AudioSource>().clip = Microphone.Start(null, true, 10, 44100);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
