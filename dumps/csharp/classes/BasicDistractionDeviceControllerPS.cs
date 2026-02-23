using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BasicDistractionDeviceControllerPS : ScriptableDeviceComponentPS
	{
		private CEnum<EPlaystyleType> _distractorType;
		private CHandle<EngDemoContainer> _basicDistractionDeviceSkillChecks;
		private CArray<CName> _effectOnStartNames;
		private CEnum<EAnimationType> _animationType;
		private CBool _forceAnimationSystem;
		private TweakDBID _overrideDistractionActionId;

		[Ordinal(107)] 
		[RED("distractorType")] 
		public CEnum<EPlaystyleType> DistractorType
		{
			get => GetProperty(ref _distractorType);
			set => SetProperty(ref _distractorType, value);
		}

		[Ordinal(108)] 
		[RED("basicDistractionDeviceSkillChecks")] 
		public CHandle<EngDemoContainer> BasicDistractionDeviceSkillChecks
		{
			get => GetProperty(ref _basicDistractionDeviceSkillChecks);
			set => SetProperty(ref _basicDistractionDeviceSkillChecks, value);
		}

		[Ordinal(109)] 
		[RED("effectOnStartNames")] 
		public CArray<CName> EffectOnStartNames
		{
			get => GetProperty(ref _effectOnStartNames);
			set => SetProperty(ref _effectOnStartNames, value);
		}

		[Ordinal(110)] 
		[RED("animationType")] 
		public CEnum<EAnimationType> AnimationType
		{
			get => GetProperty(ref _animationType);
			set => SetProperty(ref _animationType, value);
		}

		[Ordinal(111)] 
		[RED("forceAnimationSystem")] 
		public CBool ForceAnimationSystem
		{
			get => GetProperty(ref _forceAnimationSystem);
			set => SetProperty(ref _forceAnimationSystem, value);
		}

		[Ordinal(112)] 
		[RED("overrideDistractionActionId")] 
		public TweakDBID OverrideDistractionActionId
		{
			get => GetProperty(ref _overrideDistractionActionId);
			set => SetProperty(ref _overrideDistractionActionId, value);
		}

		public BasicDistractionDeviceControllerPS(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
