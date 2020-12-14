using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class reflect : MonoBehaviour
{
    private Rigidbody rb;
    private Vector3 velocity;
    public float speed = 1.0f;
    public GameObject player;
    public Transform ballspawn;
    public Transform playerspawn;
    private bool slowed = false;

    float maxCharge = 5f;
 /*   private float charge = 5f;*/
    private float chargeUse = 1f;
    public EnergyBar energyBar;
    public Energy energy;

    public GameObject[] batteries;

    AudioSource source;

/*    void Start()
    {
        energy.init();
    }*/
    // Start is called before the first frame update
    void OnEnable()
    {
        slowed = false;
        transform.position = ballspawn.position;

        rb = this.GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0, 0, 0);

        velocity = Vector3.back*speed;
        rb.AddForce(velocity, ForceMode.VelocityChange);
        //rb.velocity = Vector3.back * speed;

        energy.init();
        /*charge = maxCharge;*/

        energyBar.SetMaxEnergy(energy.charge);

        source = GetComponent<AudioSource>();

    }
    
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ReflectWall"))
        {
            //ReflectProjectile(rb, collision.contacts[0].normal);
            velocity = Vector3.Reflect(velocity, collision.contacts[0].normal);
            rb.velocity = velocity;

        }
        if (collision.gameObject.CompareTag("Player"))
        {
            //slowed = false;
            //transform.position = ballspawn.position;
            //rb.velocity = new Vector3(0, 0, 0);
            //velocity = Vector3.back * speed;
            //rb.AddForce(velocity, ForceMode.VelocityChange);
            //rb.velocity = velocity;
            /*     player.transform.position = playerspawn.position;

                 source.Stop();
                 energy.init();
                 energyBar.SetMaxEnergy(energy.charge);
                 energyBar.SetEnergy(energy.charge);

                 for (int i = 0; i < batteries.Length; i++)
                 {
                     batteries[i].SetActive(true);
                 }

                 this.gameObject.SetActive(false);*/
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        
    }

    private void ReflectProjectile(Rigidbody rb, Vector3 reflectVector)
    {
        velocity = Vector3.Reflect(velocity, reflectVector);
        rb.velocity = velocity;
    }

    // Update is called once per frame
    void Update()
    {
        velocity = rb.velocity;


        if (slowed == false)
        {
            if (energy.charge > 0)
            {
                if (Input.GetKeyDown("space"))
                {
                    UnityEngine.Debug.Log("timeslowed");
                    //speed *= .5f;
                    velocity *= .2f;
                    rb.velocity = velocity;

                    slowed = true;
                    source.Play();
                }
                //transform.Translate(Vector3.back * Time.deltaTime * speed);
            } 

        }
        else if(slowed == true)
        {
            if (energy.charge <= 0)
            {
                UnityEngine.Debug.Log("timrenromal");
                velocity *= 5.0f;
                rb.velocity = velocity;
                slowed = false;
                source.Stop();
                return;
            }

            /* charge -= chargeUse * Time.deltaTime;*/
            energy.charge -= chargeUse * Time.deltaTime;
            energyBar.SetEnergy(energy.charge);

            if (Input.GetKeyDown("space"))
            {
                UnityEngine.Debug.Log("timrenromal");
                velocity *= 5.0f;
                rb.velocity = velocity;
                slowed = false;
                source.Stop();
            }
            //transform.Translate(Vector3.back * Time.deltaTime * speed);

        }
       
    }
}
