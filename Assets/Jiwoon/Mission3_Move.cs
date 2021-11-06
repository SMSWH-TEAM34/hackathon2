using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Mission3_Move : MonoBehaviour
{
    public float speed = 3f;
    private Vector3 _direction;

    /*
    public void Direction(InputAction.CallbackContext context)
    {
        Vector2 _inputVecotr = context.ReadValue<Vector2>();
        _direction = new Vector3(_inputVecotr.x, 0, _inputVecotr.y);
    }
    */
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Move(InputAction.CallbackContext context)
    {
        Debug.Log("New input System");
        Vector2 _inputVecotr = context.ReadValue<Vector2>();
        _direction = new Vector3(_inputVecotr.x, 0, _inputVecotr.y);
        transform.Translate(_direction * speed * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
