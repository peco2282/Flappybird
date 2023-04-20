using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject wallPrefab;
    public float interval;
    public float range = 3.0F;
    
    // Start is called before the first frame update
    IEnumerator Start()
    {
        while (true)
        {
            transform.position = new Vector3(
                transform.position.x,
                Random.Range(-range, range),
                transform.position.z
                );
            Instantiate(wallPrefab, transform.position, transform.rotation);
            yield return new WaitForSeconds(interval);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
