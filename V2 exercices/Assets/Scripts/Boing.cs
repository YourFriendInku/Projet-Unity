using UnityEngine;

public class Boing : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private float speed = 10f;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Vector3 position = other.transform.position;
        Vector3 AppliedMovement = speed * new Vector3(0, 10, 0);
        other.attachedRigidbody.AddForce(AppliedMovement);
    }
}
