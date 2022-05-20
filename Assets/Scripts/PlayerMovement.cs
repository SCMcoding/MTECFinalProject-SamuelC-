using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5.0f;
    //public Transform[] CrystalWing;
    public GameObject flare;
    public AudioSource audioSource;
    private int _score;

    // Update is called once per frame
    void Update()
    {

       


        float xMove = Input.GetAxisRaw("Horizontal");
        float yMove = Input.GetAxisRaw("Vertical");

        float xMovement = xMove * speed * Time.deltaTime;
        float yMovement = yMove * speed * Time.deltaTime;

        transform.Translate(xMovement, yMovement, 0);


        


        if (Input.GetKeyDown(KeyCode.F))
        {
            Spawnflare();
        }


        void Spawnflare()

        {
            //int index = Random.Range(0, CrystalWing.Length);


            GameObject Bullet = Instantiate(flare, transform.position, flare.transform.rotation);

            Bullet.GetComponent<Bullet>().speed = Random.Range(1.0f, 5.0f);
        }




    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Mod")
        {
            Destroy(gameObject);
            
        }

      


    }

    

}






