using UnityEngine;
using System.Collections.Generic;

public class starpool : MonoBehaviour
{
     [SerializeField] private GameObject starprefab;
    [SerializeField] private int poolsize =6;
    List<GameObject> pool = new List< GameObject>();
    void Start()
    {
        for(int i=0;i<poolsize;i++)
        {
            GameObject sta = Instantiate (starprefab);
              sta.transform.position = new Vector2(  Random.Range(-5, 5), Random.Range(-2, 2)   );

            sta.SetActive(true);
            pool.Add(sta);
        }
        
     }   
    
       public  GameObject star()
    {
        foreach (GameObject sta in pool)
        {
            if(!sta.activeInHierarchy)
            {
            
                return sta;
            }
        
        }
          return null;
    }
    
}
