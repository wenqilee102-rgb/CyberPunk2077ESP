using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WorldMapPreloader : inkWidgetLogicController
	{
		private CName _splashAnim;
		private CName _spinnerAnim;
		private CName _spinnerFadeOutAnim;
		private CName _spinnerFadeInAnim;
		private CName _mapFadeOutAnim;
		private CBool _isMapLoaded;
		private CBool _isMapFadeOutStarted;
		private CBool _isSpinnerVisible;
		private CHandle<inkanimProxy> _splashProxy;
		private CHandle<inkanimProxy> _spinnerFadeOutProxy;

		[Ordinal(1)] 
		[RED("splashAnim")] 
		public CName SplashAnim
		{
			get => GetProperty(ref _splashAnim);
			set => SetProperty(ref _splashAnim, value);
		}

		[Ordinal(2)] 
		[RED("spinnerAnim")] 
		public CName SpinnerAnim
		{
			get => GetProperty(ref _spinnerAnim);
			set => SetProperty(ref _spinnerAnim, value);
		}

		[Ordinal(3)] 
		[RED("spinnerFadeOutAnim")] 
		public CName SpinnerFadeOutAnim
		{
			get => GetProperty(ref _spinnerFadeOutAnim);
			set => SetProperty(ref _spinnerFadeOutAnim, value);
		}

		[Ordinal(4)] 
		[RED("spinnerFadeInAnim")] 
		public CName SpinnerFadeInAnim
		{
			get => GetProperty(ref _spinnerFadeInAnim);
			set => SetProperty(ref _spinnerFadeInAnim, value);
		}

		[Ordinal(5)] 
		[RED("mapFadeOutAnim")] 
		public CName MapFadeOutAnim
		{
			get => GetProperty(ref _mapFadeOutAnim);
			set => SetProperty(ref _mapFadeOutAnim, value);
		}

		[Ordinal(6)] 
		[RED("isMapLoaded")] 
		public CBool IsMapLoaded
		{
			get => GetProperty(ref _isMapLoaded);
			set => SetProperty(ref _isMapLoaded, value);
		}

		[Ordinal(7)] 
		[RED("isMapFadeOutStarted")] 
		public CBool IsMapFadeOutStarted
		{
			get => GetProperty(ref _isMapFadeOutStarted);
			set => SetProperty(ref _isMapFadeOutStarted, value);
		}

		[Ordinal(8)] 
		[RED("isSpinnerVisible")] 
		public CBool IsSpinnerVisible
		{
			get => GetProperty(ref _isSpinnerVisible);
			set => SetProperty(ref _isSpinnerVisible, value);
		}

		[Ordinal(9)] 
		[RED("splashProxy")] 
		public CHandle<inkanimProxy> SplashProxy
		{
			get => GetProperty(ref _splashProxy);
			set => SetProperty(ref _splashProxy, value);
		}

		[Ordinal(10)] 
		[RED("spinnerFadeOutProxy")] 
		public CHandle<inkanimProxy> SpinnerFadeOutProxy
		{
			get => GetProperty(ref _spinnerFadeOutProxy);
			set => SetProperty(ref _spinnerFadeOutProxy, value);
		}

		public WorldMapPreloader(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
