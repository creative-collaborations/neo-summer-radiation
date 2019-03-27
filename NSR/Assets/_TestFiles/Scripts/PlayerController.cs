using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    public float speed = 3;
    private Vector3 inputs;
    public Animator anm;

    [SerializeField]
    private int fuelAmount;
    public Text fuelText;

    public GameObject dialogueBox;
    public Text dialogueText;

    // Use this for initialization
    void Start () {
        inputs = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        //BEST PRACTICE
        inputs.x = Input.GetAxis("Horizontal");
        inputs.z = Input.GetAxis("Vertical");

        transform.position += inputs * speed * Time.deltaTime;

        //ANIMATION
        if (inputs.x < -0.1)
        {
            anm.Play("left_walk");
        }

        else if (inputs.x > 0.1)
        {
            anm.Play("right_walk");
        }

        else if (inputs.z < -0.1)
        {
            anm.Play("forward_walk");
        }

        else if (inputs.z > 0.1)
        {
            anm.Play("back_walk");
        }

        else
        {
            anm.Play("forward_idle");
        }
        

        //KEYCODE
        //if (Input.GetKey(KeyCode.W))
        //{
        //    transform.position += Vector3.forward * speed * Time.deltaTime;
        //}

        //if (Input.GetKey(KeyCode.S))
        //{
        //    transform.position += Vector3.back * speed * Time.deltaTime;
        //}

        //if (Input.GetKey(KeyCode.A))
        //{
        //    transform.position += Vector3.left * speed * Time.deltaTime;
        //}

        //if (Input.GetKey(KeyCode.D))
        //{
        //    transform.position += Vector3.right * speed * Time.deltaTime;
        //}

        if (fuelAmount == 5)
        {
            dialogueBox.SetActive(true);
            dialogueText.text = "NICE.";
        }

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "collectible")
        {
            fuelAmount++;
            Destroy(collision.gameObject);

            Debug.Log("Fuel: " + fuelAmount);
            fuelText.text = fuelAmount.ToString();
        } 

        if (collision.gameObject.tag == "ufo" && fuelAmount == 5 )
        {
            Debug.Log("CONGRATULATIONS.");
            dialogueText.text = "CONGRATULATIONS.";
        }
    }
}
