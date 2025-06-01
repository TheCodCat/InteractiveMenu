using DG.Tweening;
using System;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]
public class HideService : MonoBehaviour, IService
{
	[SerializeField] private Image hideImage;
	[SerializeField] private AudioSource hideAudioSource;

	public void Hide(Action callback)
	{
		hideAudioSource.Play();

		hideImage.rectTransform
			.DOScale(1, hideAudioSource.clip.length).SetEase(Ease.InCubic)
			.OnComplete(() => callback?.Invoke());
	}
}
