using UnityEngine;

public class Charactor : MonoBehaviour
{
    private int health;
    public int Health
    {
        get => health;
        set => health = (value < 0) ? 0 : value; 
    }
    
    protected Animator anim;
    protected Rigidbody2D rb;

    public void TakeDamage(int damage)
    {
        Health -= damage;
        Debug.Log($"{this.name} took {damage} damage, Current Health: {Health}");
        Isdead();
    }

    public bool Isdead()
    {
        if (Health <= 0)
        {
            Destroy(this.gameObject);
            return true;
        }
        else
        {
            return false;
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
