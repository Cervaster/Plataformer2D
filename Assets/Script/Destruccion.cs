using UnityEngine;

public class Destruccion : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(this.gameObject, .5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
