using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerController : MonoBehaviour
{
    bool alive = true;
    public float speed = 5;
    [SerializeField] public Rigidbody rb;

    float horizontalInput;
    [SerializeField] public float horizontalMultiplier = 2;

    public int position;
    public int coins;
    public int bestPosition;

    [SerializeField] private TextMeshProUGUI textPos;
    [SerializeField] private TextMeshProUGUI textCoin;
    [SerializeField] private TextMeshProUGUI textBestPos;

    void Start()
    {
        position = 0;
        coins = 0;
        bestPosition = Save.Load().position;
        textBestPos.text = bestPosition.ToString();
    }

    private void FixedUpdate()
    {
        if (!alive) { return; }
        rb.useGravity = true;
        Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;
        Vector3 horizontalMove = transform.right * horizontalInput * speed * Time.fixedDeltaTime * horizontalMultiplier;
        rb.MovePosition(rb.position + forwardMove + horizontalMove);
    }


    void Update()
    {
        if (rb.position.y < -5)
        {
            Die();
        }
        horizontalInput = Input.GetAxis("Horizontal");
        position = (int)(rb.position.z+7);
        textCoin.text = coins.ToString();
        textPos.text = position.ToString();
    }

    public void AddCoin()
    {
        coins++;
    }

    public void Die()
    {
        alive = false;
        Saving();
        SceneManager.LoadScene("StartScene");
    }

    public void Saving()
    {
        Save.SavePlayer(this);
    }
}
