using UnityEngine;

public class startdisppear : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Me"))
        {
            turnoff();
        }
    }
    void turnoff()
    {
       gameObject. SetActive(false);
    }
}
