using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DetectionMeterEffector : gameEffector
	{
		private TweakDBID _statusEffectID;
		private CFloat _detectionStep;
		private CInt32 _maxStacks;
		private CBool _onlyHostileDetection;
		private CBool _dontRemoveStacks;
		private CHandle<redCallbackObject> _detectionListener;
		private CInt32 _currentStacks;
		private ScriptGameInstance _gameInstance;
		private entEntityID _ownerID;

		[Ordinal(0)] 
		[RED("statusEffectID")] 
		public TweakDBID StatusEffectID
		{
			get => GetProperty(ref _statusEffectID);
			set => SetProperty(ref _statusEffectID, value);
		}

		[Ordinal(1)] 
		[RED("detectionStep")] 
		public CFloat DetectionStep
		{
			get => GetProperty(ref _detectionStep);
			set => SetProperty(ref _detectionStep, value);
		}

		[Ordinal(2)] 
		[RED("maxStacks")] 
		public CInt32 MaxStacks
		{
			get => GetProperty(ref _maxStacks);
			set => SetProperty(ref _maxStacks, value);
		}

		[Ordinal(3)] 
		[RED("onlyHostileDetection")] 
		public CBool OnlyHostileDetection
		{
			get => GetProperty(ref _onlyHostileDetection);
			set => SetProperty(ref _onlyHostileDetection, value);
		}

		[Ordinal(4)] 
		[RED("dontRemoveStacks")] 
		public CBool DontRemoveStacks
		{
			get => GetProperty(ref _dontRemoveStacks);
			set => SetProperty(ref _dontRemoveStacks, value);
		}

		[Ordinal(5)] 
		[RED("detectionListener")] 
		public CHandle<redCallbackObject> DetectionListener
		{
			get => GetProperty(ref _detectionListener);
			set => SetProperty(ref _detectionListener, value);
		}

		[Ordinal(6)] 
		[RED("currentStacks")] 
		public CInt32 CurrentStacks
		{
			get => GetProperty(ref _currentStacks);
			set => SetProperty(ref _currentStacks, value);
		}

		[Ordinal(7)] 
		[RED("gameInstance")] 
		public ScriptGameInstance GameInstance
		{
			get => GetProperty(ref _gameInstance);
			set => SetProperty(ref _gameInstance, value);
		}

		[Ordinal(8)] 
		[RED("ownerID")] 
		public entEntityID OwnerID
		{
			get => GetProperty(ref _ownerID);
			set => SetProperty(ref _ownerID, value);
		}

		public DetectionMeterEffector(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
