using System.Collections;
using UnityEngine;

public class BolaFuego : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private float fuerzaBolaFuego;
    [SerializeField] private GameObject explosionPrefab;


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

    private void OnTriggerEnter2D(Collider2D elOtro)
    {
        if (elOtro.CompareTag("PlayerHitBox"))
        {
            SistemaVidas sistemasvidas = elOtro.gameObject.GetComponent<SistemaVidas>();
            sistemasvidas.RecibirDanho(20);
            Destroy(this.gameObject);
            Instantiate(explosionPrefab, this.transform.position, Quaternion.identity);
        }
    }

}
