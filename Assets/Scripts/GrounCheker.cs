using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrounCheker : MonoBehaviour
{
    Player _player;

    void Awake()
    {
        _player = GameObject.Find("Mario").GetComponent<Player>();
    }

    void OnTriggerStay2D(Collider2D col)
    {
        _player.isGrounded = true;
        _player._animator.SetBool("Jumping", false);
    }

    void OnTriggerExit2D(Collider2D col)
    {
        _player.isGrounded = false;
        _player._animator.SetBool("Jumping", true);
    }
}
