using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D rb { get; set; }
    public float speed = 250f;

    void Awake(){
        rb = GetComponent<Rigidbody2D>();
    }
    void Start(){
        Invoke(nameof(SetRandomTrajectory), 1f);
    }

    private void SetRandomTrajectory(){
        Vector2 force = Vector2.zero;
        force.x = Random.Range(-0.5f, 0.5f);
        force.y = -1;

        rb.AddForce(force.normalized * speed);
    }
}
