using System;
using UnityEngine;
using UnityEngine.Rendering;

public class Observer : MonoBehaviour
{
    public Yippe yup;
    [SerializeField] GameObject goty;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        yup.onEvent += ShitHappens;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void ShitHappens()
    {
        Pointagegng.points++;
        GameObject notGoty = GameObject.Instantiate(goty);
        Rigidbody rbNotGoty = notGoty.GetComponent<Rigidbody>();
        rbNotGoty.isKinematic = true;

        Renderer RenNotGoty = notGoty.GetComponent<Renderer>();
        RenNotGoty.material.color = Color.white;

        goty.transform.position = new Vector3(-60, 7, -128);


        Rigidbody normalGoty = goty.GetComponent<Rigidbody>();
        normalGoty.angularVelocity = Vector3.zero;
        normalGoty.linearVelocity = Vector3.zero;
    }
}
