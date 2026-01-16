using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collection : MonoBehaviour
{
    private coinManager coinManager;
    private SpriteRenderer SpriteRenderer;

    private void Start()
    {
        SpriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            coinManager = GameObject.Find("coinManager").GetComponent<coinManager>();
            
            if (SpriteRenderer.enabled == true)
            {
                coinManager.collect();
            }
            SpriteRenderer.enabled = false;


        }

    }

}
