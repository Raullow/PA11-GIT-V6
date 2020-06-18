using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float verticalInput = Input.GetAxis("Vertical");

        transform.position = transform.position + new Vector3(0 , verticalInput * speed * Time.deltaTime, 0);

        transform.position = new
        Vector3(Mathf.Clamp(transform.position.x, -8.4f, -8.4f), Mathf.Clamp(transform.position.y, -4f, 4f), transform.position.z);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Obstacle")
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
