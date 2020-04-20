using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    public GameObject G1;
    public GameObject B1;
    public GameObject G2;
    public GameObject B2;
    public GameObject G3;
    public GameObject B3;
    public GameObject G4;
    public GameObject B4;

    public float spawnRate = 1f;

    float nextSpawn = 0f;

    Vector3 baseScale;
    public Vector3 targetScale;
    

    int whatToSpawn;

    // Start is called before the first frame update
    void Start()
    {
        baseScale = transform.localScale;

        /*oxygen = GetComponent<GameObject>();
        carbon = GetComponent<GameObject>();*/
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 position = new Vector2(Random.Range(-5f, 5f), Random.Range(4.5f, 0f));

        if (nextSpawn <= 0.0f)
        {
            nextSpawn = 1f;
            whatToSpawn = Random.Range(1, 9);
            Debug.Log(whatToSpawn);

            switch (whatToSpawn)
            { 
                case 1:
                    
                    var cloneG1 = Instantiate(G1, position,Quaternion.identity);

                        Destroy(cloneG1, 1f);
                   
                    break;

                case 2:
                    var cloneB1 = Instantiate(B1, position, Quaternion.identity);

                        Destroy(cloneB1, 1f);
                    
                    break;

                case 3:
                    var cloneG2 = Instantiate(G2, position, Quaternion.identity);

                    Destroy(cloneG2, 1f);

                    break;

                case 4:
                    var cloneB2 = Instantiate(B2, position, Quaternion.identity);

                    Destroy(cloneB2, 1f);

                    break;

                case 5:
                    var cloneG3 = Instantiate(G3, position, Quaternion.identity);

                    Destroy(cloneG3, 1f);

                    break;

                case 6:
                    var cloneB3 = Instantiate(B3, position, Quaternion.identity);

                    Destroy(cloneB3, 1f);

                    break;

                case 7:
                    var cloneG4 = Instantiate(G4, position, Quaternion.identity);

                    Destroy(cloneG4, 1f);

                    break;

                case 8:
                    var cloneB4 = Instantiate(B4, position, Quaternion.identity);

                    Destroy(cloneB4, 1f);

                    break;
            }

        }

        //set next spawn time
        nextSpawn =  nextSpawn - Time.deltaTime;
        //Debug.Log(nextSpawn);
    }



}
