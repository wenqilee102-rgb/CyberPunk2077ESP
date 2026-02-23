using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiHUDVideoStartEvent : CVariable
	{
		private CUInt64 _videoPathHash;
		private CBool _playOnHud;
		private CBool _fullScreen;
		private CBool _useFullscreenVideoState;
		private CBool _keepWidescreenAspectRatio;
		private Vector2 _position;
		private Vector2 _size;
		private CBool _skippable;
		private CBool _isLooped;
		private CBool _forceVideoFrameRate;

		[Ordinal(0)] 
		[RED("videoPathHash")] 
		public CUInt64 VideoPathHash
		{
			get => GetProperty(ref _videoPathHash);
			set => SetProperty(ref _videoPathHash, value);
		}

		[Ordinal(1)] 
		[RED("playOnHud")] 
		public CBool PlayOnHud
		{
			get => GetProperty(ref _playOnHud);
			set => SetProperty(ref _playOnHud, value);
		}

		[Ordinal(2)] 
		[RED("fullScreen")] 
		public CBool FullScreen
		{
			get => GetProperty(ref _fullScreen);
			set => SetProperty(ref _fullScreen, value);
		}

		[Ordinal(3)] 
		[RED("useFullscreenVideoState")] 
		public CBool UseFullscreenVideoState
		{
			get => GetProperty(ref _useFullscreenVideoState);
			set => SetProperty(ref _useFullscreenVideoState, value);
		}

		[Ordinal(4)] 
		[RED("keepWidescreenAspectRatio")] 
		public CBool KeepWidescreenAspectRatio
		{
			get => GetProperty(ref _keepWidescreenAspectRatio);
			set => SetProperty(ref _keepWidescreenAspectRatio, value);
		}

		[Ordinal(5)] 
		[RED("position")] 
		public Vector2 Position
		{
			get => GetProperty(ref _position);
			set => SetProperty(ref _position, value);
		}

		[Ordinal(6)] 
		[RED("size")] 
		public Vector2 Size
		{
			get => GetProperty(ref _size);
			set => SetProperty(ref _size, value);
		}

		[Ordinal(7)] 
		[RED("skippable")] 
		public CBool Skippable
		{
			get => GetProperty(ref _skippable);
			set => SetProperty(ref _skippable, value);
		}

		[Ordinal(8)] 
		[RED("isLooped")] 
		public CBool IsLooped
		{
			get => GetProperty(ref _isLooped);
			set => SetProperty(ref _isLooped, value);
		}

		[Ordinal(9)] 
		[RED("forceVideoFrameRate")] 
		public CBool ForceVideoFrameRate
		{
			get => GetProperty(ref _forceVideoFrameRate);
			set => SetProperty(ref _forceVideoFrameRate, value);
		}

		public gameuiHUDVideoStartEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
