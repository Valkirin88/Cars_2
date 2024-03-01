using UnityEngine;

public class CarController : MonoBehaviour
{
    [SerializeField]
    private Transform _wheelPosition;
    [SerializeField]
    private Rigidbody _carRigidbody;

    private Vector3 _directionVector;
    private float _speed = 30000f;

    private void Update()
    {
        //if (Input.GetKey("w"))
        //{
        //    transform.position += Vector3.forward * Time.deltaTime * _speed;
        //}
    }

    private void GetVector()
    {
        
    }

    private void FixedUpdate()
    {
        if (Input.GetKey("w"))
        {
            _directionVector = Vector3.right * _speed;
            _carRigidbody.AddRelativeTorque(_directionVector);
            
        }
        if (Input.GetKey("s"))
        {
            _directionVector = Vector3.right * _speed;
            _carRigidbody.AddRelativeTorque(-_directionVector);
        }
        if (Input.GetKey("a"))
        {
            _directionVector = (_directionVector + Vector3.left * _speed).normalized; 
        }

        if (Input.GetKey("d"))
        {
            _directionVector = (_directionVector + Vector3.right * _speed).normalized;
        }

    }
}
