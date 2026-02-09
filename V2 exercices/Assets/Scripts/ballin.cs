using UnityEngine;

public class ballin : MonoBehaviour
{
    bool youreNormal = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if( !youreNormal || transform.position.x ==2)
        {
            youreNormal = false;
            transform.position = new Vector3(transform.position.x -1 ,transform.position.y, transform.position.z);
        }
        
        else if(transform.position.x == -2 || youreNormal){
            transform.position = new Vector3(transform.position.x + 1, transform.position.y, transform.position.z);
        }
    }

}
