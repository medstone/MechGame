using UnityEngine;
using System.Collections;

public class mechControl : MonoBehaviour {
    Animator anim;
    Rigidbody bod;
    public float runSpeed;
    public float accel;
    bool dash = false;

	// Use this for initialization
	void Start () {
        anim = gameObject.GetComponent<Animator>();
        bod = gameObject.transform.parent.gameObject.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        dash = Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.LeftShift);
        Vector3 vel = Vector3.zero;
        if (!dash) {
            if (Input.GetKey(KeyCode.W))
            {
                vel.z += 1;
            }
            if (Input.GetKey(KeyCode.S))
            {
                vel.z -= 1;
            }
            if (Input.GetKey(KeyCode.A))
            {
                vel.x -= 1;
            }
            if (Input.GetKey(KeyCode.D))
            {
                vel.x += 1;
            }
        }
        print(vel);
        bod.velocity = vel.normalized * runSpeed;
        anim.SetBool("Dash", dash);
	}

    void FixedUpdate()
    {
        if (!dash)
        {
            anim.speed = 1;
        }
        else
        {
            anim.speed += accel;
        }
    }
}
