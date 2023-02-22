using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 3;
    public float maxHp = 20;

    Vector3 input;

    bool dead = false;

    float hp;

    Weapon weapon;




    // Start is called before the first frame update
    void Start()
    {
        hp = maxHp;
        weapon = GetComponent<Weapon>();    
    }

    // Update is called once per frame
    void Update()
    {
        input = new Vector3(Input.GetAxis("Horizontal"),0,Input.GetAxis("Vertical"));

        bool fireKeyDown = Input.GetKeyDown(KeyCode.J);
        bool fireKeyPressed = Input.GetKey(KeyCode.J);
        bool changeWeapon = Input.GetKeyDown(KeyCode.Q);

        if (!dead) 
        {
            Move();
            weapon.Fire(fireKeyDown, fireKeyPressed);

            if (changeWeapon) 
            {
                ChangeWeapon();
            }
        }
    }

    private void ChangeWeapon()
    {
        int w = weapon.Change();
    }

    private void Move()
    {
        input = input.normalized;
        transform.position += input * speed * Time.deltaTime;

        if (input.magnitude>0.1f)
        {
            transform.forward = input;
        }

        //Vector3 temp = transform.position;

        //const float BORDER = 5;

        //if (temp.z > BORDER) { temp.z = BORDER; }
        //if (temp.z < -BORDER) { temp.z = -BORDER; }
        //if (temp.x > BORDER) { temp.x = BORDER; }
        //if (temp.x > -BORDER) { temp.x = -BORDER; }

        //transform.position = temp;
    }
}
