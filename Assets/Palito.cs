using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Palito : MonoBehaviour
{
    [SerializeField] float Speed;
    [SerializeField] string Player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float move = Input.GetAxis(Player) * Speed * Time.deltaTime;

        transform.Translate(0, move, 0);
    }
}
