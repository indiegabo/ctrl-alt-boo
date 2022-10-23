using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Boo.Playing
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class PlayerMovement : MonoBehaviour
    {
        #region Inspector

        [SerializeField]
        private float _speed = 10;

        [SerializeField]
        private float _damping = 4;

        #endregion

        #region Fields

        // Self Components
        private Rigidbody2D _rigidbody;

        // External Components
        private Camera _camera;

        // Values
        private Vector2 _direction;
        private Vector2 _mousePosisition;

        #endregion

        #region Monobehaviour

        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody2D>();
            _camera = Camera.main;
        }

        private void Update()
        {
            RotateTowardsMouse();
        }

        private void FixedUpdate()
        {
            Move();
        }

        #endregion

        #region Movement And Rotation

        private void Move()
        {
            _rigidbody.AddForce((_direction * _speed - _rigidbody.velocity) / Time.fixedDeltaTime / _damping);
        }

        private void RotateTowardsMouse()
        {
            var mousePosition = _camera.ScreenToWorldPoint(_mousePosisition);
            var playerPosition = transform.position;

            transform.rotation = Quaternion.LookRotation(
                Vector3.forward,
                mousePosition - playerPosition
            );
        }

        #endregion

        #region Input Callbacks

        public void OnMove(InputAction.CallbackContext context)
        {
            _direction = context.ReadValue<Vector2>();
        }

        public void OnLook(InputAction.CallbackContext context)
        {
            _mousePosisition = context.ReadValue<Vector2>();
        }

        #endregion
    }
}
