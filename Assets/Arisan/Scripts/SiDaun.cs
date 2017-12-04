using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SiDaun : MonoBehaviour {

    public float upForce = 200f;

    private bool isDead = false;
    private Rigidbody2D rb2d;

	// Use this for initialization
	void Start () {
        this.rb2d = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

		if (!isDead)
        {

            if (Input.GetMouseButtonDown(0))
            {
                this.rb2d.velocity = Vector2.zero;
                this.rb2d.AddForce(new Vector2(1, this.upForce));
            }

        }

	}

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Ground"))
        {
            this.isDead = true;
            Debug.Log("Die");
        }
    }
}
