using UnityEngine;

public class SistemaVidas : MonoBehaviour
{
    [SerializeField] private float vidas;
    [SerializeField] GameObject explosion;

    public float Vidas { get => vidas; set => vidas = value; }

    public void RecibirDanho(float danhorecibido)
    {
        vidas -= danhorecibido;
        if (vidas <= 0)
        {
            Destroy(this.gameObject);
            Instantiate(explosion, this.transform.position, Quaternion.identity);
        }

    }

}