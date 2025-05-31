using System.Collections;
using UnityEngine;

public class Wizard : MonoBehaviour
{
    [SerializeField] private GameObject bolaFuego;
    [SerializeField] private Transform puntoDisparo;
    [SerializeField] private float tiempoDisparo;
    [SerializeField] private float danhoAtaque;
    private Animator anim;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       anim= GetComponent<Animator>();
        StartCoroutine(RutinaAtaque());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator RutinaAtaque()
    {
        while (true)
        {
           anim.SetTrigger("atacar");
            yield return new WaitForSeconds(3);
        }
    }

    private void LanzarBola()
    {
        Instantiate(bolaFuego, puntoDisparo.position, transform.rotation);
    }
}
