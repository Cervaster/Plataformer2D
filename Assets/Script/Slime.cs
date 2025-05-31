using System.Collections;
using UnityEditor;
using UnityEngine;
using UnityEngine.Video;

public class Slime : MonoBehaviour
{
    [SerializeField] private Transform[] puntos;
    [SerializeField] private float velocidadPatrulla;
    [SerializeField] private float danhoAtaque;
    private Vector3 destinoActual;
    private int indiceActual = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        destinoActual = puntos[indiceActual].position;
        StartCoroutine(Patrulla());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Patrulla()
    {
        while (true)
        {
            while (transform.position != destinoActual)
            {
                transform.position = Vector3.MoveTowards(transform.position, destinoActual, velocidadPatrulla * Time.deltaTime);
                yield return null;
            }
            Debug.Log("llego");
            DefinirNuevoDestino();
        }
    }
    private void DefinirNuevoDestino()
    {
        indiceActual++;
        if(indiceActual >= puntos.Length)
        {
            indiceActual = 0;
        }
        destinoActual = puntos[indiceActual].position;
        EnFocarDestino();

    }
    private void EnFocarDestino()
    {
        if (destinoActual.x > transform.position.x)
        {
            transform.localScale = Vector3.one;
        }
        else 
        { 
            transform.localScale = new Vector3(-1,1,1); 
        }

    }

    private void OnTriggerEnter2D(Collider2D elOtro)
    {
        if (elOtro.CompareTag("DeteccionPlayer"))
        {
           Debug.Log("Detecte al jugador");
        }
        else if (elOtro.CompareTag("PlayerHitBox"))
        {
            SistemaVidas sistemasvidas = elOtro.gameObject.GetComponent<SistemaVidas>();
            sistemasvidas.RecibirDanho(20);
        }
    }
}
