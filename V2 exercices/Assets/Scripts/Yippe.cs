using System;
using UnityEngine;

public class Yippe : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    public event Action onEvent;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {

       onEvent();
        
    }
}
