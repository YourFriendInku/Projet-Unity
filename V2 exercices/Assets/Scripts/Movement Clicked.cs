using System.Collections;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class MovementClicked : MonoBehaviour
{
    Coroutine coroutine;
    Coroutine coroutineV2;
    [SerializeField] float rotationSpeed;
    
    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            Vector2 mousePosition = Mouse.current.position.ReadValue();
           
            //la variable qui permet d'indiquer si l'element choisi est un point utilisable, c genre une ligne entre le point choisi et le perso, ca permet de check les positions
            Ray ray = Camera.main.ScreenPointToRay(mousePosition);

            if(Physics.Raycast(ray, out RaycastHit hit))
            {
                Vector3 direction = (hit.point - transform.position).normalized;

                if (coroutine != null && coroutineV2 !=null) StopAllCoroutines();

                coroutine = StartCoroutine(Translate(direction));
                coroutineV2 = StartCoroutine(Rotate(direction));
            }
        }
    }

    private IEnumerator Translate(Vector3 direction)
    {
        

        while ((transform.position - direction).magnitude > 0.5f)
        {
            transform.position += direction * Time.deltaTime; 
            
            yield return null;
        }
    }

    private IEnumerator Rotate(Vector3 direction)
    {
        Quaternion finalRotation = Quaternion.LookRotation(direction);

        while (transform.rotation != finalRotation)
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation, finalRotation, rotationSpeed * Time.deltaTime);
            yield return null;
        }
    }
}
