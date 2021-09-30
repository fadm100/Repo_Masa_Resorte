using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlTeclado : MonoBehaviour
{
    public Vector2 startPos;
    public Vector2 direction;
    public bool directionChosen;
    //Propiedades
    //[Range(0, 30)] // modificador limita la velocidad entre 0 y 30
    //public float speed = 5f;
    [Range(0, 30), Tooltip("Velocidad lineal del tanque")] // modificador limita la velocidad entre 0 y 30
    private float speed = 10f;
    
    [Range(0, 90), Tooltip("Velocidad de giro del tanque")]
    private float TurnSpeed = 45f;

    private float horizontalInput, verticalInput;
    
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("Arranque del juego"+gameObject.name);
    }

    // Update is called once per frame
    void Update()
    {
        // Track a single touch as a direction control.
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            // Handle finger movements based on touch phase.
            switch (touch.phase)
            {
                // Record initial touch position.
                case TouchPhase.Began:
                    startPos = touch.position;
                    directionChosen = false;
                    break;

                // Determine direction by comparing the current touch position with the initial one.
                case TouchPhase.Moved:
                    //direction = touch.position - startPos;
                    direction = startPos - touch.position;
                    break;

                // Report that a direction has been chosen when the finger is lifted.
                case TouchPhase.Ended:
                    directionChosen = true;
                    break;
            }
        }
        if (directionChosen)
        {
            Debug.Log("La entrada horizontal es: " + direction.x);
            // Something that uses the chosen direction...
            horizontalInput = Input.GetAxis("Horizontal");
            //Debug.Log("La entrada horizontal es: "+horizontalInput);
        
            //verticalInput = Input.GetAxis("Vertical");
            //verticalInput = Input.GetTouch(0)
            //Debug.Log("La entrada vertical es: "+verticalInput);
        
            transform.Translate(speed*Time.deltaTime*Vector3.forward*direction.x/10);// quitando this igual funciona
            //transform.Translate(TurnSpeed*Time.deltaTime*Vector3.right*horizontalInput);
            transform.Rotate(TurnSpeed*Time.deltaTime*Vector3.up*horizontalInput);
            directionChosen = false;
        }
        
        //this.transform.Translate(0,0,(float) 0.01); vehiculo hacia adelante con desplazqmientos cortos
        //this.transform.Translate(0,0,1); vehiculo hacia adelante con desplazqmientos de un metro
        //this.transform.Translate(Vector3.forward); vehiculo hacia adelante con desplazqmientos de un metro
        // S=S0+v*t*(dirección) --> S0 no hace falta
        //this.transform.Translate(10*Time.deltaTime*Vector3.forward);
        
        //if (Input.GetMouseButton(0))
        //{
            // Algo que se hace mietras el click este activo
        //}
        

        

        //transform.localScale();
    }
}
