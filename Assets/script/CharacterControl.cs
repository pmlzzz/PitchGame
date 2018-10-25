using UnityEngine;
using System.Collections;

public class CharacterControl : MonoBehaviour {
    private const float moveSpeed = 1.0f;
    public bool isAnimation = false;
    public Sprite[] sprites;
    private SpriteRenderer sr;
    private int fps = 12;
    private float timer = 0;

    //GameObject go = GameObject.FindGameObjectsWithTag("recorder");
    GameObject go;
    float height;

	// Use this for initialization
	void Start () {
        go = GameObject.Find("recorder");
        sr = this.GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
        height = GameObject.Find("Audio Source").GetComponent<audio>().change;

        this.transform.Translate(0, height/20, 0);

        if (isAnimation)
        {
            timer += Time.deltaTime;
            int currentFrame = (int)(timer * fps);
            int currentSprite = currentFrame % 6;
            sr.sprite = sprites[currentSprite];
        }

        Vector3 currentPos = this.transform.position;

        if(currentPos.y>= 200.51f)
        {
            this.transform.position = new Vector3(currentPos.x, 200.51f, currentPos.z);
        }else if(currentPos.y <= -200.51f)
        {
            this.transform.position = new Vector3(currentPos.x, -200.51f, currentPos.z);
        }
    }

    public void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Award")
        {
            //Debug.Log("true");
            Award award = collider.GetComponent<Award>();
            collider.gameObject.SendMessage("traceMC");

        }
        else if(collider.tag == "testAward")
        {
            
            Award award = collider.GetComponent<Award>();
            collider.gameObject.SendMessage("traceMC");
        }

    }
}
