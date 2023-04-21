using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float flightSpeed = 5f;
    private Vector3 respawn;
    [SerializeField] Animator animate;
    float Horizontal;
    float Vertical;
    float xBound = 7.5f;
    public Rigidbody2D rb;
    ButtonPressed Up;
    ButtonPressed Down;



    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Up = GameObject.Find("UpButton").GetComponent<ButtonPressed>();
        Down = GameObject.Find("DownButton").GetComponent<ButtonPressed>();

    }

    void Update()
    {
        Vertical = Input.GetAxisRaw("Vertical");
        PlaneMovementr(-Vertical);

        if (Up.IsButtonPressed)
        {
            PlaneMovementr(-1);
        }
        if (Down.IsButtonPressed)
        {
            PlaneMovementr(1);
        }



    }


    public void PlaneMovementr(float direction)
    {
        Vector2 move = new Vector2(direction, Horizontal);
        transform.Translate(move * flightSpeed * Time.deltaTime);
        float y = Mathf.Clamp(transform.position.y, -xBound, xBound);
        transform.position = new Vector2(-7.5f, y);

    }


}

