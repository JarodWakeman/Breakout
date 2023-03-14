using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnExtraBalls : MonoBehaviour
{
    public GameObject ballSpawner;
    public GameObject ball;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject gameObj;
        gameObj = GameObject.Instantiate(ball, ballSpawner.transform.position, ballSpawner.transform.rotation);


        Destroy(gameObject);
        
    }
}
