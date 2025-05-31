using UnityEngine;

public class BolaFuego : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private float fuerzaBolaFuego;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    //transform.forward ----> eje z 
    //transform.right ----> eje x
    //transform.up ----> eje y  
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(transform.right * fuerzaBolaFuego, ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
