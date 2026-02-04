using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class MovementClicked : MonoBehaviour
{
    Coroutine coroutine;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            Vector2 mousePosition = Mouse.current.position.ReadValue();
           
            //la variable qui permet d'indiquer si l'element choisi est un point utilisable, c genre une ligne entre le point choisi et le perso, ca permet de check les positions
            Ray ray = Camera.main.ScreenPointToRay(mousePosition);

            if(Physics.Raycast(ray, out RaycastHit hit))
            {
                Vector3 way = (transform.position - hit.point).normalized;
                transform.LookAt(hit.point);
                

                if (coroutine != null) { 
                    StopCoroutine(coroutine);
                    
                    
                }
                coroutine = StartCoroutine(OnBouge(way));
            }

            
        }
    }

    private IEnumerator OnBouge(Vector3 theWay)
    {

        while((transform.position - theWay).magnitude > 0.5f)
        {
            transform.position -= theWay * Time.deltaTime; 
            
            yield return null;
        }
        
        
    }
}
