using UnityEngine;
using System.Collections;


public class q : MonoBehaviour {

    public Animation clip;
    public float speed;
    public float sensivity;

	void Start () {
        clip.Play("stand");
        animation["run"].speed = 1.7f;
        animation["jump"].speed = 1.5f;
	}
	
	void Update () {
        //float moveUP = -Input.GetAxis("Mouse Y")* sensivity * Time.deltaTime;
        float moveSide = Input.GetAxis("Mouse X") * sensivity * Time.deltaTime;

        transform.Rotate(0, moveSide, 0);
        //transform.Rotate(0, moveUP, 0);
        if (clip.IsPlaying("jump")) 
        {
            return;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(0, 0, 2f);
            clip.Play("jump");
            return;
        }
        else if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, speed);
            clip.Play("run");
            return;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -speed);
            clip.Play("run");
            return;
        }
        else
        {
            clip.Play("stand");
        }
	}
}
