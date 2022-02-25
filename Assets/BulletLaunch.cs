using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BulletLaunch : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float speed;
    public GameObject enemyPrefab;
    public Vector3 offset;
    public float time;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.Space))
        {
            GameObject tempBullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            tempBullet.transform.position = transform.position;
            //Camera camera = GetComponentInChildren<Camera>();
            tempBullet.GetComponent<Rigidbody>().velocity = Camera.main.transform.rotation*Vector3.forward*speed;
           
        }
        time = time + Time.deltaTime;
        if(time>=3.0f)
        {
            float x = Random.Range(Random.Range(-5f,-15f),Random.Range(5f,15f));
            float y = Random.Range(1f, 3f);
            float z = Random.Range(Random.Range(-5f, -15f), Random.Range(5f, 15f));
            Instantiate(enemyPrefab, new Vector3(x, y, z), Quaternion.identity);
            time = 0.0f;

        }
}

    
}
