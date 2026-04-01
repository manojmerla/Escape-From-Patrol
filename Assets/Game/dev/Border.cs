using UnityEngine;

public class Border : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Me"))
        {
            Enemy.instance.Chase(other.transform);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Me"))
        {
            Enemy.instance.BackToPatrol();
        }
    }
}