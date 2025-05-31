using UnityEngine;

public class SistemaVidas : MonoBehaviour
{
    [SerializeField] private float vidas;

    public void RecibirDanho(float danhorecibido)
    {
        vidas -= danhorecibido;
        if (vidas <= 0)
        {
            Destroy(this.gameObject);
        }
        
    }
}
