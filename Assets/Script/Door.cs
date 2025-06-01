using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    private bool isPlayerInDoor = false;
    [SerializeField] private TextMeshProUGUI mensaje;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mensaje.gameObject.SetActive(false); 
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "Level1")
        {
            if (Input.GetKeyDown(KeyCode.E) && isPlayerInDoor == true)
            {
                SceneManager.LoadScene("Level2"); 
            }
        }

        if (SceneManager.GetActiveScene().name == "Level2")
        {
            if (Input.GetKeyDown(KeyCode.E) && isPlayerInDoor == true)
            {
                SceneManager.LoadScene("GameOver"); 
            }
        }
        
    }

    public void Entrar()
    {
        SceneManager.LoadScene("Level1", LoadSceneMode.Single); 
    }

    public void Salir()
    {
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }

    private void OnTriggerEnter2D(Collider2D elOtro)
    {
        if (elOtro.CompareTag("PlayerHitBox"))
        {
            isPlayerInDoor = true;
            mensaje.text = "Presiona E para entrar al siguiente nivel";
            mensaje.gameObject.SetActive(true);
        }
        else if (elOtro.CompareTag("PlayerHitBox"))
        {
            isPlayerInDoor = false;
            mensaje.gameObject.SetActive(false);
        }
    }
}
