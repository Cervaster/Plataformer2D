using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    private bool isPlayerInDoor = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && isPlayerInDoor == true)
        {
            SceneManager.LoadScene("Level2"); // Cambia "Nivel2" por el nombre de tu escena de destino
        }
    }

    private void OnTriggerEnter2D(Collider2D elOtro)
    {
        if (elOtro.CompareTag("PlayerHitBox"))
        {
            isPlayerInDoor = true;
            Debug.Log("Player is in door area. Press E to enter the next level.");
        }
        else if (elOtro.CompareTag("PlayerHitBox"))
        {
            isPlayerInDoor = false;
        }
    }
}
