using UnityEngine;
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
 
     // Use this for initialization
     void Start () {
        
        x = Random.Range(-velocidadMax, velocidadMax);
        z = Random.Range(-velocidadMax, velocidadMax);
        angulo = Mathf.Atan2(x, z) * (180 / 3.141592f) + 90;
        transform.localRotation = Quaternion.Euler( 0, angulo, 0);
     }
     
     // Update is called once per frame
     void Update () {
 
         tiempo += Time.deltaTime;
 
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
	        Debug.Log("Something hit..");
			GameObject expl = Instantiate(explosion, transform.position, Quaternion.identity) as GameObject;
			Destroy(expl, 3);
			for(float i = transform.localPosition.y; i < 5; i+=1){
				transform.localPosition = new Vector3(transform.localPosition.x,i,transform.localPosition.z);
			};
			expl = Instantiate(explosion, transform.position, Quaternion.identity) as GameObject;
			Destroy(expl, 3);
			Destroy(gameObject);
            PointCounter.count++;     
		}
     }

  }


