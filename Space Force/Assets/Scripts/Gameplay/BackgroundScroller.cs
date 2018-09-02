using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour 
{
	[SerializeField] private float _backgroundScrollSpeed = 0.5f;

	private Material _textureMaterial;
	private Vector2 _offset;

	void Start() 
	{
		_textureMaterial = GetComponent<Renderer>().material;
		_offset = new Vector2(0, _backgroundScrollSpeed);
	}

	void Update()
	{
		_textureMaterial.mainTextureOffset += _offset * Time.deltaTime;
	}
}
