using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
    [SerializeField]
    float speed = 3f;
    public void MoveToDirection(Vector3 direction)
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }
}
