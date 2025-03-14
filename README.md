using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
   private int health = 10;

   public void TakeDamage(int damage)
   {
	health -= damage;
	print ("Player´health:" + health);

   }
public AudioSource audioSource;

public AudiClip damageSound;

public void TakeDamage(int damage)
{
	health -= damage;

	if(health > 0)
	{
			audioSource.PlayOneShot(damageSound);

	}
	else
	{
		int sceneIndex = SceneManager.GetActiveScene().buildIndex;
		SceneManager.LoadScene(sceneIndex);

	}


}
}
