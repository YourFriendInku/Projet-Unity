using UnityEngine;

public class JeuDeTailleV2 : MonoBehaviour
{
    [SerializeField]
    int vitesseTransformation = 1;
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
        else if (transform.localScale.magnitude <= 3f)
        {
            agrandir = true;
        }
        if (agrandir)
        {
            transform.localScale += new Vector3(0.01f, 0.01f, 0.01f) * Time.deltaTime * vitesseTransformation;

        } else if(!agrandir)
        {
            transform.localScale -= new Vector3(0.01f, 0.01f, 0.01f) * Time.deltaTime * vitesseTransformation;
        }
    }
}
