using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class playerScript02 : MonoBehaviour
{

    public Rigidbody rocketPrefab;
    public Transform barrelEnd;

   // public GameObject projectile;
   public float bulletSpeed;

    /*
    public float moveForce = 0f;
    private Rigidbody rbody;
    public GameObject bullet;
    public Transform gun;
    public float shootRate = 0f;
    public float shootForce = 0f;
    private float shootRateTimeStamp = 0f;
    */

    // Start is called before the first frame update
    void Start()
    {

      //  rbody = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetButtonDown("Fire1"))
        {
            Rigidbody rocketInstance;
            rocketInstance = Instantiate(rocketPrefab, barrelEnd.position, barrelEnd.rotation) as Rigidbody;
            rocketInstance.AddForce(barrelEnd.forward * bulletSpeed);

            Debug.Log("playerScript02");
        }




        /*
        if (Input.touchCount >= 0)
        {

            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {

                Vector3 touchPos = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
                Vector3 dir = touchPos - (new Vector3(transform.position.x, transform.position.y));
                dir.Normalize();
                GameObject bullet = Instantiate(projectile, transform.position, Quaternion.identity) as GameObject;
                bullet.GetComponent<Rigidbody2D>().velocity = dir * bulletSpeed;
            }
        }
        */

        /*
        float h = Input.GetAxisRaw("Horizontal") * moveForce;
        float v = Input.GetAxisRaw("Vertical") * moveForce;

        rbody.velocity = new Vector3(h, v, 0);

        if(Input.GetMouseButtonDown(0))   //Input.GetKey(KeyCode.Space)
        {
            if(Time.time > shootRateTimeStamp)
            {
                GameObject go = (GameObject)Instantiate(bullet, gun.position, gun.rotation);
                go.GetComponent<Rigidbody>().AddForce(gun.forward * shootForce);
                shootRateTimeStamp = Time.time + shootRate;

            }
                       
        }
        */





    }
}
