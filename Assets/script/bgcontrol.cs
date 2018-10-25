using UnityEngine;
using System.Collections;

public class bgcontrol : MonoBehaviour {

    private float moveSpeed = 20.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        Vector3 currentPos = this.transform.position;
        if (currentPos.x <= -91.27f)
        {
            this.transform.position = new Vector3(currentPos.x+2* 91.27f, currentPos.y, currentPos.z);
        }
	}
}
