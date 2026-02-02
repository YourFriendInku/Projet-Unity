using TMPro;
using UnityEngine;

public class Pointagegng : MonoBehaviour
{
    public TextMeshProUGUI txt;
    public static int points = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        txt.text = points.ToString();
    }
}
