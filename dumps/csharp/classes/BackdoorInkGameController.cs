using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BackdoorInkGameController : MasterDeviceInkGameControllerBase
	{
		private inkWidgetReference _idleGroup;
		private inkWidgetReference _connectedGroup;
		private CName _introAnimationName;
		private CName _idleAnimationName;
		private CName _glitchAnimationName;
		private CHandle<inkanimProxy> _runningAnimation;
		private CHandle<redCallbackObject> _onGlitchingListener;
		private CHandle<redCallbackObject> _onIsInDefaultStateListener;
		private CHandle<redCallbackObject> _onShutdownModuleListener;
		private CHandle<redCallbackObject> _onBootModuleListener;

		[Ordinal(20)] 
		[RED("IdleGroup")] 
		public inkWidgetReference IdleGroup
		{
			get => GetProperty(ref _idleGroup);
			set => SetProperty(ref _idleGroup, value);
		}

		[Ordinal(21)] 
		[RED("ConnectedGroup")] 
		public inkWidgetReference ConnectedGroup
		{
			get => GetProperty(ref _connectedGroup);
			set => SetProperty(ref _connectedGroup, value);
		}

		[Ordinal(22)] 
		[RED("IntroAnimationName")] 
		public CName IntroAnimationName
		{
			get => GetProperty(ref _introAnimationName);
			set => SetProperty(ref _introAnimationName, value);
		}

		[Ordinal(23)] 
		[RED("IdleAnimationName")] 
		public CName IdleAnimationName
		{
			get => GetProperty(ref _idleAnimationName);
			set => SetProperty(ref _idleAnimationName, value);
		}

		[Ordinal(24)] 
		[RED("GlitchAnimationName")] 
		public CName GlitchAnimationName
		{
			get => GetProperty(ref _glitchAnimationName);
			set => SetProperty(ref _glitchAnimationName, value);
		}

		[Ordinal(25)] 
		[RED("RunningAnimation")] 
		public CHandle<inkanimProxy> RunningAnimation
		{
			get => GetProperty(ref _runningAnimation);
			set => SetProperty(ref _runningAnimation, value);
		}

		[Ordinal(26)] 
		[RED("onGlitchingListener")] 
		public CHandle<redCallbackObject> OnGlitchingListener
		{
			get => GetProperty(ref _onGlitchingListener);
			set => SetProperty(ref _onGlitchingListener, value);
		}

		[Ordinal(27)] 
		[RED("onIsInDefaultStateListener")] 
		public CHandle<redCallbackObject> OnIsInDefaultStateListener
		{
			get => GetProperty(ref _onIsInDefaultStateListener);
			set => SetProperty(ref _onIsInDefaultStateListener, value);
		}

		[Ordinal(28)] 
		[RED("onShutdownModuleListener")] 
		public CHandle<redCallbackObject> OnShutdownModuleListener
		{
			get => GetProperty(ref _onShutdownModuleListener);
			set => SetProperty(ref _onShutdownModuleListener, value);
		}

		[Ordinal(29)] 
		[RED("onBootModuleListener")] 
		public CHandle<redCallbackObject> OnBootModuleListener
		{
			get => GetProperty(ref _onBootModuleListener);
			set => SetProperty(ref _onBootModuleListener, value);
		}

		public BackdoorInkGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
