using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ItemCollector : MonoBehaviour
{
   public static int scores;
    [SerializeField] private Text bananaText;
    [SerializeField] private AudioSource collectSoundEffect;
    public void Start()
    {
        scores = PlayerPrefs.GetInt("CurrentScore");
    }    
   private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Banana"))
        {
            collectSoundEffect.Play();
            Destroy(collision.gameObject);
            scores++;
            bananaText.text = "Banana: " + scores;
            PlayerPrefs.SetInt("CurrentScore", scores); 
        }
    } 
    
}
