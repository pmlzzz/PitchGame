using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {
    public int score = 0;
    private GUIText gt;

	// Use this for initialization
	void Start () {
        gt = GameObject.Find("score").GetComponent<GUIText>();

    }
	
	// Update is called once per frame
	void Update () {
        gt.text = "Score:" + score;
        Debug.Log(score);
	}
}
