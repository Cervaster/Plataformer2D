using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    [SerializeField] private float vidas;
    [SerializeField] private float damage;

    protected float Vidas { get => vidas; set => vidas = value; }
    protected float Damage { get => damage; set => damage = value; }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected virtual void Attack()
    {

    }
    
}
