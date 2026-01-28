using UnityEngine;


public class CameraFollowing : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] float high = 10f;
    [SerializeField] float xEtender = 2f;
    [SerializeField] float yExtender = 2f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (player != null)
        {
            Vector2 playerPosition = new Vector2(player.transform.position.x,player.transform.position.z);
            transform.position = new Vector3(playerPosition.x + xEtender, high,playerPosition.y + yExtender);
        }
    }

    void LateUpdate()
    {

    }
}
