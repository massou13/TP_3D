using UnityEngine;
using UnityEngine.InputSystem;

public class AxleSteering : MonoBehaviour
{
    private InputAction steeringAction;
    private float curentRotation = 0;
    //atribut braquage et vitesse 
    public float rotationSpeed = 50f; // Vitesse de rotation de la barre
    //public float steeringSpeed = 50f; // Vitesse de rotation de l'essieu
    public Transform leftWheel; // Référence à la roue gauche
    public Transform rightWheel; // Référence à la roue droite
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        steeringAction = new InputAction("Steering", InputActionType.Value);
        steeringAction.AddCompositeBinding("1DAxis")
            .With("Positive", "<Keyboard>/d")
            .With("Negative", "<Keyboard>/a")
            .With("Positive", "<Keyboard>/rightArrow")
            .With("Negative", "<Keyboard>/leftArrow");
            
        steeringAction.Enable();
    }

    // Update is called once per frame
    void Update()
    {
       // Obtenir l'entrée de l'utilisateur pour la rotation
        float horizontalInput = steeringAction.ReadValue<float>();// Flèches gauche/droite ou A/D

        // Calculer l'angle de rotation
        float rotationAmount = horizontalInput * rotationSpeed * Time.deltaTime;
        transform.localRotation = Quaternion.Euler(rotationAmount, 0, 0);
        // Appliquer la rotation à la barre
        //transform.Rotate(0, rotationAmount, 0);
        
    }

}
