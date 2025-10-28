using UnityEngine;

public class Rock : Weapon
{
    public Rigidbody2D rb;
    public Vector2 force;


    public override void Move()
    {
        rb.AddForce(force);
    }

    public override void OnHitWith(Character obj)
    {
        if (obj is Player)
        {
            obj.TakeDamage(this.damage);
            Destroy(this.gameObject);
        }
        
            //Destroy(this.gameObject);
    }

    void Start()
    {
        damage = 40;
        force = new Vector2(GetShootDirection() * 180, 400);
        Move();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
