using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public AudioClip PointScored;
    public AudioClip GameOverSound;

    internal void Start()
    {

    }

    internal void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            GetComponent<Rigidbody2D>().position = new Vector2(2.225f, 4f);
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            ScoreKeeper.Reset();
        }
    }

    internal void OnTriggerEnter2D(Collider2D other)
    {
        switch (other.gameObject.tag)
        {
            case "Target":
                GetComponent<Rigidbody2D>().position = new Vector2(2.225f, 4f);
                GetComponent<Rigidbody2D>().velocity = Vector2.zero;
                ScoreKeeper.AddToScore(1f);
                GetComponent<AudioSource>().PlayOneShot(PointScored);
                break;
            case "Drain":
                ScoreKeeper.GameOver();
                GetComponent<AudioSource>().PlayOneShot(GameOverSound);
                break;
        }
    }
}
