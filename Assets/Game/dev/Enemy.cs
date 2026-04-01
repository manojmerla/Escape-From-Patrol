using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public static Enemy instance;
    [SerializeField]private GameObject panel;

    public Transform[] points;
    public float speed = 2f;

    public Transform target;

    private int index = 0;
    private bool isChasing = false;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        target = points[index];
        panel.SetActive(false);
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(
            transform.position,
            target.position,
            speed * Time.deltaTime
        );

        if (!isChasing && Vector2.Distance(transform.position, target.position) < 0.1f)
        {
            index++;
            if (index >= points.Length)
                index = 0;

            target = points[index];
        }
    }

    public void Chase(Transform player)
    {
        isChasing = true;
        target = player;
    }

    public void BackToPatrol()
    {
        isChasing = false;
        target = points[index];
    }
   void OnCollisionEnter2D (Collision2D other)
   {
    if(other.gameObject.CompareTag("Me"))
    {
       panel.SetActive(true);
    }
   } 
}