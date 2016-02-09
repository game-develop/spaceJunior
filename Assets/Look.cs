using UnityEngine;
using System.Collections;

public class Look : MonoBehaviour
{

    private float upDoRot;

    public GameObject currentPlanet;
    public Animation clip;
    public float sensivity;

    // Use this for initialization
    void Start()
    {
        upDoRot = 0;
        clip.Play("stand");
    }

    void OnGUI()
    {
        Event e = Event.current;
        //Vector3 v = rigidbody.velocity;
        //if (e.keyCode == KeyCode.UpArrow)
        //rigidbody.velocity = transform.TransformVector(0, 15, 0);
    }

    void OnCollisionEnter(Collision collision)
    {
        currentPlanet = collision.gameObject;
    }

    void Update()
    {

        float moveSide = Input.GetAxis("Mouse X") * sensivity * Time.deltaTime;
        transform.rigidbody.MoveRotation(transform.rigidbody.rotation * Quaternion.Euler(0, 0, -moveSide));

        upDoRot += Input.GetAxis("Mouse Y") * sensivity * Time.deltaTime;
        if (upDoRot > 88) upDoRot = 88;
        if (upDoRot < 45) upDoRot = 45;
        Camera.main.transform.localRotation = Quaternion.Euler(-upDoRot, 0, 0);

        if (currentPlanet == null) return;

        clip.Play("run");
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            rigidbody.velocity = transform.TransformVector(0, 15, 0);
        }
        else if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            rigidbody.velocity = transform.TransformVector(0, -15, 0);
        } else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            rigidbody.velocity = transform.TransformVector(15, 0, 0);
        } else if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            rigidbody.velocity = transform.TransformVector(-15, 0, 0);
        }
        else
        {
            clip.Play("stand");
        }
        
        /*if (Input.GetKey(KeyCode.LeftArrow))
        {
            Vector3 vv = new Vector3(0, 0, 1);
            transform.rigidbody.MoveRotation(transform.rigidbody.rotation * Quaternion.Euler(vv.x, vv.y, vv.z));
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Vector3 vv = new Vector3(0, 0, -1);
            transform.rigidbody.MoveRotation(transform.rigidbody.rotation * Quaternion.Euler(vv.x, vv.y, vv.z));
        }*/

        //jump
        /*
        Ray ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 0.0f));
        if (Input.GetMouseButton(0))
        {
            rigidbody.velocity = ray.direction * 10;
            currentPlanet = null;
        }
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            
        }*/
    }
}
