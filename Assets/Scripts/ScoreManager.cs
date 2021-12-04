using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    private int m_Score;
    [SerializeField] private Text scoreTxt;

    private void Start()
    {
        m_Score = 0;
        scoreTxt.text = m_Score.ToString();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Obstacle"))
        {
            m_Score++;
            scoreTxt.text = m_Score.ToString();
            Destroy(other.gameObject);
        }
    }
}
