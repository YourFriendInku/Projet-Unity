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
        Vector3 movmeentApplied = speed * new Vector3(mouvement.x, 0, mouvement.y);
        rigidbody.AddForce(movmeentApplied);
    }
}