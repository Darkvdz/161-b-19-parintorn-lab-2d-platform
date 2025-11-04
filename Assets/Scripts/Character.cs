using UnityEngine;
using UnityEngine.UI;

public abstract class Character : MonoBehaviour
{
    private int health;
    public int Health
    {
        get => health;
        set => health = (value < 0) ? 0 : value; 
    }
    
    public Slider hpSlider;
    
    protected Animator anim;
    protected Rigidbody2D rb;

    //Initialize variable
    public void Init(int startHealth)
    {
        Health = startHealth;
        Debug.Log($"{this.name} is initialize Health : {this.Health}");
        
        if (hpSlider != null)
        {
            hpSlider.maxValue = startHealth;
            hpSlider.value = Health;
        }
        
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        if (hpSlider != null)
        {
            hpSlider.value = Health;
            print(Health);
        }
        
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
        /*Health = maxHealth;
        slider.maxValue = maxHealth;
        slider.value = Health;*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
