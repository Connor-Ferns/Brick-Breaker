using UnityEngine.Serialization;
using UnityEngine;
using UnityEngine.InputSystem;

public class Paddle : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector2 dir;

    public float speed = 30f;

    void Awake(){
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.A)){
            dir = Vector2.left;
        }
        else if(Input.GetKey(KeyCode.D)){
            dir = Vector2.right;
        } 
        else{
            dir = Vector2.zero;
        }
    }

    void FixedUpdate(){
        if(dir == Vector2.zero){
            return;
        }
        rb.AddForce(dir * speed);
    }
}
