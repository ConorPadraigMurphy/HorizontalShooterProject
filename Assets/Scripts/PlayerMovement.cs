using System.Collections;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float flightSpeed = 5f;
    private Vector3 respawn;
    [SerializeField] Animator animate;
    float Horizontal;
    float Vertical;
    float xBound = 7.5f;
    //private Animation animate;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Horizontal = Input.GetAxisRaw("Horizontal");
        Vertical = Input.GetAxisRaw("Vertical");
        Vector2 move = new Vector2(-Vertical, Horizontal);
        transform.Translate(move * flightSpeed * Time.deltaTime);

        float y = Mathf.Clamp(transform.position.y, -xBound, xBound);
        transform.position = new Vector2(-7.5f, y);
    }
}

