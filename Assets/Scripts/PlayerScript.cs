using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    SpriteRenderer sprite;
    Rigidbody2D rigidbody;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow)) 
        {
            sprite.flipX = true;
            rigidbody.linearVelocity = new Vector2(-3f, rigidbody.linearVelocity.y);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            sprite.flipX = false;
            rigidbody.linearVelocity = new Vector2(3f, rigidbody.linearVelocity.y);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody.linearVelocity = new Vector2(0, 8f);
        }
    }
}
