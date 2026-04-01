using UnityEngine;

public class playerscript : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float speed = 3;
    public Vector2 direction;
    public Animator aim;

    void Update()
    {
        float moveh = Input.GetAxis("Horizontal");
        float movev = Input.GetAxis("Vertical");

        direction = new Vector2(moveh * speed, movev * speed).normalized;
        rb.velocity = new Vector2(direction.x * speed, direction.y * speed);

        if (moveh != 0 || movev != 0)
            aim.SetBool("Walk", true);
        else
            aim.SetBool("Walk", false);
    }
}