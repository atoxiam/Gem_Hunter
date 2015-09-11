using UnityEngine;
using System.Collections;
using Quantum_Asset;

namespace Quantum_Asset
{
    public class CharacterMovement : MonoBehaviour
    {
        CharacterClass Ball;
        CharacterClass player;

        int vertical = 3;
        int horizontal = 3;

        Rigidbody2D _rigid;
        // Use this for initialization
        void Start()
        {
            Ball = GetComponent<CharacterClass>();
            _rigid = GetComponent<Rigidbody2D>();
            Debug.Log(Ball.CurrentLvl + "  " + Ball.Health + "  " + Ball.Mana);
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetAxis("Fire1") > 0)
            {
                Ball.Fireball();
            }
            else if (Input.GetAxis("Fire2") > 0)
            {
                Ball.Melee();
            }

            if (Input.GetAxis("Horizontal") < 0) {
                _rigid.velocity = new Vector2(-horizontal, 0);
            } else if(Input.GetAxis("Horizontal") > 0) {
                _rigid.velocity = new Vector2(horizontal, 0);
            } else if (Input.GetAxis("Vertical") > 0) {
                _rigid.velocity = new Vector2(0, vertical);
            } else if (Input.GetAxis("Vertical") < 0) {
                _rigid.velocity = new Vector2(0, -vertical);
            }  else {
                _rigid.velocity = new Vector2(0, 0);
            }
        }
    }
}
