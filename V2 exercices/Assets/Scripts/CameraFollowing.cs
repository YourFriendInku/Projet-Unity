using UnityEngine;


public class CameraFollowing : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] float high = 10f;
    [SerializeField] float xExtender = 2f;
    [SerializeField] float yExtender = 20f;
    [SerializeField] float zExtender = -10f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (player != null)
        {
            Vector3 playerPosition = new Vector3(player.transform.position.x,player.transform.position.y,player.transform.position.z);
            transform.position = new Vector3(playerPosition.x + xExtender, playerPosition.y + yExtender, playerPosition.z + zExtender);
        }
    }

    void LateUpdate()
    {

    }
}
