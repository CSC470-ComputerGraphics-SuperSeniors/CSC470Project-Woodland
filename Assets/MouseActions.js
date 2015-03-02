public var punchAnimation : AnimationClip;
public var kickAnim : AnimationClip;

public var PunchSound: AudioSource;
public var KickSound: AudioSource;  

function Start () {
	animation[punchAnimation.name].wrapMode = WrapMode.Once;
	animation[punchAnimation.name].layer = 1;
	
	animation[kickAnim.name].wrapMode = WrapMode.Once;
	animation[kickAnim.name].layer = 1;


	var aSources = GetComponents(AudioSource);
	PunchSound = aSources[1];
	KickSound = aSources[2];
}

var flag;
function Update () {

	 if (animation.IsPlaying(punchAnimation.name) || animation.IsPlaying(kickAnim.name)){
	      flag = true;
	   } else {
	       flag = false; }

	if(Input.GetMouseButtonDown(0) && !flag) {

	
	animation.Play(punchAnimation.name);
	PunchSound.volume = Random.Range(0.8f, 1);
	PunchSound.pitch = Random.Range(0.8f, 1.5f);
	PunchSound.Play();
	
	}
	if(Input.GetMouseButtonDown(1) && !flag) {
		animation.Play(kickAnim.name);
		KickSound.volume = Random.Range(0.2f, 0.5f);
		KickSound.pitch = Random.Range(0.8f, 1.0f);
		KickSound.Play();

	}
}