using UnityEngine;

public class Ant : Enemy
{

    [SerializeField] Vector2 velocity;
    public Transform[] movePoints;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        base.Init(25);

        DamageHit = 20;
        velocity = new Vector2 (-1.0f, 0.0f);

    }

    public override void Behavior()
    {
        rb.MovePosition(rb.position + velocity*Time.fixedDeltaTime);

        //move left and over left 
        if(velocity.x < 0 && rb.position.x <= movePoints[0].position.x)
        {
            Flip();
        }

        if (velocity.x > 0 && rb.position.x >= movePoints[1].position.x)
        {
            Flip();
        }
    }

    public void Flip()
    {
        velocity.x *= -1;
        Vector3 theScale=transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }


    private void FixedUpdate()
    {
        Behavior();
        //Debug.Log(Time.fixedDeltaTime);
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
