using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float startX;
    [SerializeField] private float endX;
    
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
        if (transform.position.x < endX)
        {
            transform.position = new Vector2(startX, transform.position.y);
        }
    }
}
