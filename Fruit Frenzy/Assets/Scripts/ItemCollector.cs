using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int fruit = 0;

    [SerializeField] private Text fruitText;

    [SerializeField] private AudioSource collectionSoundEffect;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Berry"))
        {
            collectionSoundEffect.Play();
            Destroy(collision.gameObject);
            fruit++;
            fruitText.text = "Fruits: " + fruit;
        }
    }
}
