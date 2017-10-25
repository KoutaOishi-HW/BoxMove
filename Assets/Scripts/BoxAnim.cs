using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BoxAnim : MonoBehaviour {
	private Animator animator;
	private string[] randomAnimationString = {"Emotion0","Emotion1","Emotion2","Emotion3","Emotion4"} ;

	private void Start () {
		animator = GetComponent<Animator>();
		RandomAnim ();
	}

	private void RandomAnim ()
	{
		string randomEmotion = randomAnimationString [Random.Range (0, 5)];

		EmotionText (randomEmotion);
		
		animator.Play (randomEmotion,0, 0.0f);
	}

	/// アニメーション名表示
	[SerializeField]Text emotionText;
	private void EmotionText (string randomEmotion)
	{
		emotionText.text = randomEmotion;
	}
}
