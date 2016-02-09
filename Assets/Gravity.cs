using UnityEngine;
//using System.Collections;

public class Gravity : MonoBehaviour
{

    GameObject hero;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        foreach (Transform tplanet in transform)
        {
            foreach (Transform planet in transform)
            {
                if (tplanet == planet)
                    continue;
                if (planet.tag == "Player" && planet.GetComponent<Look>().currentPlanet==null) return;
                float distance = Vector3.Distance(tplanet.transform.position, planet.transform.position);
                if (distance > (tplanet.lossyScale.x + planet.lossyScale.x) * 0.7)
                    continue;
                Vector3 v = tplanet.transform.position - planet.transform.position;
                float delta = 10 / distance * planet.rigidbody.mass * tplanet.rigidbody.mass;
                v *= delta;
                planet.rigidbody.AddForce(v);
            }
        }
    }
}

