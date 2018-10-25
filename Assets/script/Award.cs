using UnityEngine;
using System.Collections;

public class Award : MonoBehaviour {
    public GameObject awardA;
    public GameObject awardB;
    public GameObject awardC;

    public float awardRateA = 7.0f;
    public float awardRateB = 5.0f;
    public float awardRateC = 4.0f;


    // Use this for initialization
    void Start () {
        //InvokeRepeating("createAwardA", 1, awardRateA);
       // InvokeRepeating("createAwardB", 2, awardRateB);
       // InvokeRepeating("createAwardC", 3, awardRateC);
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void createAwardA()
    {
        float height = Random.Range(-22.22f, 22.22f);
        GameObject.Instantiate(awardA, new Vector3(transform.position.x, height, 0), Quaternion.identity);
    }
    public void createAwardB()
    {
        float height = Random.Range(-22.22f, 22.22f);
        GameObject.Instantiate(awardB, new Vector3(transform.position.x, height, 0), Quaternion.identity);
    }
    public void createAwardC()
    {
        float height = Random.Range(-22.22f, 22.22f);
        GameObject.Instantiate(awardC, new Vector3(transform.position.x, height, 0), Quaternion.identity);
    }

}
