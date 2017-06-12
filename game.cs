public void Start(){
	
	//Helpful feedback:
	Debug.Log("there is an extra line carriage above me");
}

public void Update(){

	Debug.Log("FRAME");

	int data = Input.GetAxisRaw("Horizontal");
	//Interaction
	Interaction(data);

}

public void Interaction(int data){
	//create awesome stuff
}