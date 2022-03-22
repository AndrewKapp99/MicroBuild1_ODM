using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharMove : MonoBehaviour
{
    [Header("Movement")]
    [SerializeField] private float force;
    [SerializeField] private float maxSpeed;
    [SerializeField] private Transform cam;
    [Range(0, 5)] public float stopFacter;
    [Range(0, 5)] public float counterForceMagnitude;
    public float x, y, z;

    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        x = Input.GetAxis("Horizontal");
        z = Input.GetAxis("Vertical");
        y = 0f;

        rb.drag = 0;

        if (Input.GetKey(KeyCode.Q))
        {
            y = 1f;
        }
        if (Input.GetKey(KeyCode.E))
        {
            y = -1f;
        }

        Vector3 CamFwd = cam.forward;
        Vector3 CamRt = cam.right;

        CamFwd.y = 0f;
        CamRt.y = 0f;

        CamFwd = CamFwd.normalized;
        CamRt = CamRt.normalized;

        Vector3 direction = new Vector3(x, y, z);
        direction = direction.normalized;

        Vector3 d = (CamFwd * direction.z + CamRt * direction.x + new Vector3(0, direction.y, 0));
        Vector3 moveDirection = d.normalized;

        rb.AddForce(moveDirection * force);

        if (rb.velocity.magnitude >= maxSpeed)
        {
            rb.drag = 0.3f;
            rb.AddForce(-(rb.velocity.normalized) * force * counterForceMagnitude);
        }

        if (x == 0 && z == 0)
        {
            rb.drag = stopFacter;
        }
    }
}
