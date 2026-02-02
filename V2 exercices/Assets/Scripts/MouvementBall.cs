using UnityEngine;
using UnityEngine.InputSystem;

public class MouvementBall : MonoBehaviour
{
    private InputAction _move;
    private Rigidbody rigidbody;
    [SerializeField]
    private float speed = 10f;
    private void Start()
    {
        _move = InputSystem.actions.FindAction("Move");
        rigidbody = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        Vector2 mouvement = _move.ReadValue<Vector2>();
        Vector3 movmeentApplied =  new Vector3(mouvement.x * speed, 0, mouvement.y * speed);
        rigidbody.AddForce(movmeentApplied);

        if (rigidbody.position.y <= -20)
        {
            rigidbody.position = new Vector3(-60, 7, -128);
            rigidbody.linearVelocity = Vector3.zero;
            rigidbody.angularVelocity = Vector3.zero;
        }
    }
}