using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myrigidbody;
    public float flapStrength;
    public LogicScript logicScript;

    public bool isBirdAlive = true;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("LogicScript Loaded");
        logicScript = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        // Input.touchCount > 0 ||
        if (Input.touchCount > 0 && isBirdAlive)
        {

            myrigidbody.velocity = Vector2.up * flapStrength;

        }

    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision Occured");
        logicScript.GameOver();
        isBirdAlive = false;
    }

}
