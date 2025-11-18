using UnityEngine;

public class Mouvcoux : MonoBehaviour
{
    public float speed = 10f; // Vitesse de rotation
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         // Faire tourner la roue autour de l'axe Y
        transform.Rotate(0, speed * Time.deltaTime, 0);
    }
}
