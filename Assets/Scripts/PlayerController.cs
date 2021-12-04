using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float increment;
    [SerializeField] private float minHeight;
    [SerializeField] private float maxHeight;
    [SerializeField] private int health;

    [SerializeField] private Text healthTxt;
    [SerializeField] private GameObject gameOverPanel;

    private Vector2 m_TargetPosition;

    private void Start()
    {
        healthTxt.text = health.ToString();
        gameOverPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxHeight)
        {
            m_TargetPosition = new Vector2(transform.position.x, transform.position.y + increment);
        }
        
        if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minHeight)
        {
            m_TargetPosition = new Vector2(transform.position.x, transform.position.y - increment);
        }

        transform.position = Vector3.MoveTowards(transform.position, m_TargetPosition, speed * Time.deltaTime);
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        healthTxt.text = health.ToString();
        if (health <= 0)
        {
            gameOverPanel.SetActive(true);
            Time.timeScale = 0;
            Destroy(gameObject);
        }
    }
}
