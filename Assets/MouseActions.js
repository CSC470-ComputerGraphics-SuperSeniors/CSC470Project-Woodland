public var punchAnimation : AnimationClip;
public var kickAnim : AnimationClip;

function Start () {
	animation[punchAnimation.name].wrapMode = WrapMode.Once;
	animation[punchAnimation.name].layer = 1;
	
	animation[kickAnim.name].wrapMode = WrapMode.Once;
	animation[kickAnim.name].layer = 1;
}

var flag;
function Update () {

	 if (animation.IsPlaying(punchAnimation.name) || animation.IsPlaying(kickAnim.name)){
	      flag = true;
	   } else {
	       flag = false; }

	if(Input.GetMouseButtonDown(0) && !flag) {
	
	animation.Play(punchAnimation.name); 
	
	}
	if(Input.GetMouseButtonDown(1) && !flag) {
	animation.Play(kickAnim.name); 
	}
}