using UnityEngine;

public class score : MonoBehaviour
{
    public int value = 1;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Me"))
        {
            scoremanger.instance.Addscore(value);
        }
    }
}