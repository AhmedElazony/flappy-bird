using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject objectToSpawn;

    public float wait = 1f;
    public float height = 1f;
    private float timer = 0f;
    


    // Update is called once per frame
    void Update()
    {
        if (timer > wait)
        {
            GameObject newobjectToSpawn = Instantiate(objectToSpawn);
            newobjectToSpawn.transform.position = transform.position + new Vector3(0, Random.Range(-height, height));
            Destroy(newobjectToSpawn, 8f);

            timer = 0f;
        }

        timer += Time.deltaTime;
    }

    
}
