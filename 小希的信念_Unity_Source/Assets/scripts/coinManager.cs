using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinManager : MonoBehaviour
{
    public int number = 7;
    public GameObject Button1;
    void Start()
    {

    }

    void Update()
    {
        if (number.Equals(0))
        {
            Debug.Log("Ω· ¯”Œœ∑");
            Button1.SetActive(true);
        }
    }

    public void collect()
    {
        number -= 1;
    }
}
