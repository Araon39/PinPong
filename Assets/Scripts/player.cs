using UnityEngine;
using Mirror;

public class player : NetworkBehaviour
{
    private Rigidbody rb;

    public float speed;
    private Vector3 input;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        if (!isLocalPlayer) return; //�� ��������� ���� ���������� ��� ���� ��� �� ��������� ����� (���������� ������ � ������ ������, � �� � ������)
        input = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + input * speed / 100);
    }
}
