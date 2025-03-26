using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour
{
    [SerializeField]
    private float maximumSpinSpeed = 200;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().angularVelocity = Random.Range(-maximumSpinSpeed, maximumSpinSpeed);
    }
}
