#pragma strict


var anim : Animator; 
var target : Transform; //the enemy's target
 var moveSpeed = 3; //move speed
 var rotationSpeed = 3; //speed of turning
 var range : float=10f;
 var range2 : float=10f;
 var stop : float=0;
 var myTransform : Transform; //current transform data of this enemy
 function Awake()
 {
     myTransform = transform; //cache transform data for easy access/preformance
 }
  
 function Start()
 {
      target = GameObject.FindWithTag("Player").transform; //target the player
	  anim = GetComponent("Animator");
 }
  
 function Update () {
     //rotate to look at the player
     var distance = Vector3.Distance(myTransform.position, target.position);
     if (distance<=range2 &&  distance>=range){
     myTransform.rotation = Quaternion.Slerp(myTransform.rotation,
     Quaternion.LookRotation(target.position - myTransform.position), rotationSpeed*Time.deltaTime);
     }
   
 
     else if(distance<=range && distance>stop){
 
     //move towards the player
     myTransform.rotation = Quaternion.Slerp(myTransform.rotation,
     Quaternion.LookRotation(target.position - myTransform.position), rotationSpeed*Time.deltaTime);
     myTransform.position += myTransform.forward * moveSpeed * Time.deltaTime;
	 anim.SetBool("Walking", true);
     }
     else if (distance<=stop) {
     myTransform.rotation = Quaternion.Slerp(myTransform.rotation,
     Quaternion.LookRotation(target.position - myTransform.position), rotationSpeed*Time.deltaTime);
     }
      else if (distance > range && distance > range2)
	  anim.SetBool("Walking", false);

  
 }