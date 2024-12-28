using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D _rb;
    [SerializeField] Object_Behaviour _objectBehaviour;

    float _inputHorisontal = 200f;
    float _playerSpeed = 5f;
    
    // Start is called before the first frame update

    void Start()
    {

        _rb = gameObject.GetComponent<Rigidbody2D>();
        _objectBehaviour.SpawnObject();

    }

    // Update is called once per frame
    void Update()
    {
        _inputHorisontal = Input.GetAxisRaw("Horizontal");
        
        if (_inputHorisontal != 0)
        {
            _rb.AddForce(new Vector2(_inputHorisontal * _playerSpeed,0f));
        }
    }
}
