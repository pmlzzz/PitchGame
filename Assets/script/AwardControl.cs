using UnityEngine;
using System.Collections;

public class AwardControl : MonoBehaviour {
    public float speed = 20.0f;
    GameObject mc;
    private bool isHit = false;

	// Use this for initialization
	void Start () {
        mc = GameObject.Find("character");
    }
	
	// Update is called once per frame
	void Update () {
        float timer = Time.deltaTime;
        this.transform.Translate(Vector3.left * timer * speed);
        if (this.transform.position.x <= -48f)
        {
            Destroy(this.gameObject);
        }

        if (isHit)
        {
            transform.position = Vector3.Lerp(transform.position, mc.transform.position, Time.deltaTime * 1f);
            if (transform.position.x <= mc.transform.position.x)
            {
                Destroy(this.gameObject);
            }
        }
    }

    public void traceMC()
    {
        isHit = true;
    }
}
