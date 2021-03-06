﻿using UnityEngine;
using System.Collections;

public class MoveBug : MonoBehaviour {

	public float velocidadMax;  
    public float xMax;
    public float zMax;
    public float xMin;
	public float zMin;
	public GameObject explosion;
         
     private float x;
     private float z;
     private float tiempo;
     private float angulo;

    //public AudioSource[] aSources;
    public AudioSource DyingSound;
    public AudioSource KillStreakFive;
    public AudioSource KillStreakTen;
    public AudioSource KillStreakFifteen;
    public AudioSource KillStreakTwenty;
    public AudioSource KillStreakTwentyFive;
    public AudioSource KillStreakThirty;
    public AudioSource fiveKillMusic;
 
     // Use this for initialization
     void Start () {

        PointCounter.totalBugs++;
        
        x = Random.Range(-velocidadMax, velocidadMax);
        z = Random.Range(-velocidadMax, velocidadMax);
        angulo = Mathf.Atan2(x, z) * (180 / 3.141592f) + 90;
        transform.localRotation = Quaternion.Euler( 0, angulo, 0);
     }
     
     // Update is called once per frame
     void Update () {
 
         tiempo += Time.deltaTime;

         xMax += (PointCounter.count / 10);
         zMax += (PointCounter.count / 10);
 
         if (transform.localPosition.x > xMax) {
             x = Random.Range(-velocidadMax, 0.0f);
             angulo = Mathf.Atan2(x, z) * (180 / 3.141592f) + 90;
             transform.localRotation = Quaternion.Euler(0, angulo, 0);
             tiempo = 0.0f; 
         }
         if (transform.localPosition.x < xMin) {
             x = Random.Range(0.0f, velocidadMax);
             angulo = Mathf.Atan2(x, z) * (180 / 3.141592f) + 90;
             transform.localRotation = Quaternion.Euler(0, angulo, 0); 
             tiempo = 0.0f; 
         }
         if (transform.localPosition.z > zMax) {
             z = Random.Range(-velocidadMax, 0.0f);
             angulo = Mathf.Atan2(x, z) * (180 / 3.141592f) + 90;
             transform.localRotation = Quaternion.Euler(0, angulo, 0); 
             tiempo = 0.0f; 
         }
         if (transform.localPosition.z < zMin) {
             z = Random.Range(0.0f, velocidadMax);
             angulo = Mathf.Atan2(x, z) * (180 / 3.141592f) + 90;
             transform.localRotation = Quaternion.Euler(0, angulo, 0);
             tiempo = 0.0f; 
         }
 
 
         if (tiempo > 1.0f) {
             x = Random.Range(-velocidadMax, velocidadMax);
             z = Random.Range(-velocidadMax, velocidadMax);
             angulo = Mathf.Atan2(x, z) * (180 / 3.141592f) + 90;
             transform.localRotation = Quaternion.Euler(0, angulo, 0);
             tiempo = 0.0f;
         }
 
         transform.localPosition = new Vector3(transform.localPosition.x + x, transform.localPosition.y, transform.localPosition.z + z);
         
        
     }

     void OnTriggerEnter(Collider collider){
		if(collider.gameObject.tag == "appendages"){
            PointCounter.count++;
            if(PointCounter.count % 5 == 0 && !fiveKillMusic.isPlaying)
                fiveKillMusic.Play();
            switch(PointCounter.count){
                case 5:
                    KillStreakFive.Play();
                    break;
                case 10:
                    KillStreakTen.Play();
                    break;
                case 15:
                    KillStreakFifteen.Play();
                    break;
                case 20:
                    KillStreakTwenty.Play();
                    break;
                case 25:
                    KillStreakTwentyFive.Play();
                    break;
                case 30:
                    KillStreakThirty.Play();
                    break;
                default:
                    break;
            }
			GameObject expl = Instantiate(explosion, transform.position, Quaternion.identity) as GameObject;
			Destroy(expl, 3);
			for(float i = transform.localPosition.y; i < 10; i+=1){
				transform.localPosition = new Vector3(transform.localPosition.x,i,transform.localPosition.z);
			};
			expl = Instantiate(explosion, transform.position, Quaternion.identity) as GameObject;
			Destroy(expl, 3);
            DyingSound.Play();
			Destroy(gameObject);
            
            
               
		}
     }

  }


