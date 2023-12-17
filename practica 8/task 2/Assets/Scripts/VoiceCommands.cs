using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class VoiceCommands : MonoBehaviour
{
    public TextMeshProUGUI uiText; 
    public float jumpAmount = 6.0f;
    private bool isGrounded;
    public Rigidbody rb;
    private Animation animator;

    void Start()
    {
        // Get the Animator component attached to the GameObject
        animator = GetComponent<Animation>();

        if (animator == null)
        {
            Debug.LogError("Animator component not found on the GameObject.");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        isGrounded = true;
    }
    // Update is called once per frame
    void Update()
    {
        if (uiText.text == " Jump." || uiText.text == " jump."|| uiText.text == " JUMP")
        {
            if (isGrounded)
            {
                uiText.text = "";
                rb.AddForce(Vector3.up * jumpAmount, ForceMode.Impulse);
                isGrounded = false;
            }
        }
        if (uiText.text == " Run." || uiText.text == " run." || uiText.text == " RUN")
        {
            animator.Play("run");
        }
         if (uiText.text != " Run." && uiText.text != " run." && uiText.text != " RUN")
        {
            animator.Stop("run");
        }
    }
}
