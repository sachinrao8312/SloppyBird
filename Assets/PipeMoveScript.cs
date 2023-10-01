using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipesSript : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed = 3;

    public float destroyPipesAt = -26f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;

        if (transform.position.x < destroyPipesAt)
        {
            Debug.Log("Destroying pipes");
            Destroy(gameObject);
        }
    }
}