using UnityEngine;

public class StarSpwan : MonoBehaviour
{
    private starpool pools;

    void Start()
    {

        pools = FindFirstObjectByType<starpool>();

        if (pools == null)
        {
        
            return;
        }
  InvokeRepeating(nameof(Spawn), 0.5f, 0.5F);
    }

    void Spawn()
    {


        GameObject newstar = pools.star();

        if (newstar == null)
        {
          
            return;
        }

        newstar.transform.position = new Vector2(
            Random.Range(-5, 5),
        Random.Range(-2, 2)
        );

        newstar.SetActive(true);

      
    }
}