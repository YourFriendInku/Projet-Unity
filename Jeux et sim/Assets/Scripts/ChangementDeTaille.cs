using UnityEngine;

public class JeuDeTaille : MonoBehaviour
{

    
    bool agrandir = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.localScale = new Vector3(3.00f, 3.00f, 3.00f);
        Debug.Log("Taille initiale : " + transform.localScale);
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.localScale.magnitude >= 8f)
        {
            agrandir = false;
        }
        else if (transform.localScale.magnitude <= 1f)
        {
            agrandir = true;
        }
        if (agrandir)
        {
            transform.localScale += new Vector3(0.01f, 0.01f, 0.01f);

        } else if(!agrandir)
        {
            transform.localScale -= new Vector3(0.01f, 0.01f, 0.01f);
        }
    }
}
