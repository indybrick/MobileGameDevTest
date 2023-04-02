using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    Rigidbody rb;
    private Touch touch;
    float speedMultipler = 0.01f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        if (rb == null)
            Debug.Log("Could not get player rigidbody");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Moved)
            {
                transform.position = new Vector3(
                    transform.position.x + touch.deltaPosition.x * speedMultipler,
                    transform.position.y,
                    transform.position.z + touch.deltaPosition.y * speedMultipler);
            }
        }
    }
}
