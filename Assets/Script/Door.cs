using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D elOtro)
    {
        if (elOtro.CompareTag("DeteccionPlayer"))
        {
            Debug.Log("Presiona E");

        }
        else if (elOtro.CompareTag("PlayerHitBox"))
        {
            NextLevel();
        }
    }

    private void NextLevel()
    {
        Debug.Log("Jugador ha entrado en la puerta");

        if (Input.GetKeyDown(KeyCode.E))
        {
        SceneManager.LoadScene("Level2"); // Cambia "Nivel2" por el nombre de tu escena de destino
        }
    }
}
