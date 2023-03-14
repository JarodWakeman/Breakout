using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreasePaddleSize : MonoBehaviour
{
    public GameObject ball;
    public GameObject paddle;
    Vector3 temp;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        temp = transform.localScale;

        temp.x += 0.25f;

        paddle.transform.localScale = temp;

        Destroy(gameObject);
    }
}
