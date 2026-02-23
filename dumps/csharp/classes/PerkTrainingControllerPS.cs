using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PerkTrainingControllerPS : ScriptableDeviceComponentPS
	{
		private TweakDBID _interactionTweakDBID;
		private CFloat _loopTime;
		private CFloat _jackinStartTime;
		private CBool _isCorePerk;
		private CBool _perkGranted;
		private CBool _wasDetected;

		[Ordinal(107)] 
		[RED("interactionTweakDBID")] 
		public TweakDBID InteractionTweakDBID
		{
			get => GetProperty(ref _interactionTweakDBID);
			set => SetProperty(ref _interactionTweakDBID, value);
		}

		[Ordinal(108)] 
		[RED("loopTime")] 
		public CFloat LoopTime
		{
			get => GetProperty(ref _loopTime);
			set => SetProperty(ref _loopTime, value);
		}

		[Ordinal(109)] 
		[RED("jackinStartTime")] 
		public CFloat JackinStartTime
		{
			get => GetProperty(ref _jackinStartTime);
			set => SetProperty(ref _jackinStartTime, value);
		}

		[Ordinal(110)] 
		[RED("isCorePerk")] 
		public CBool IsCorePerk
		{
			get => GetProperty(ref _isCorePerk);
			set => SetProperty(ref _isCorePerk, value);
		}

		[Ordinal(111)] 
		[RED("perkGranted")] 
		public CBool PerkGranted
		{
			get => GetProperty(ref _perkGranted);
			set => SetProperty(ref _perkGranted, value);
		}

		[Ordinal(112)] 
		[RED("wasDetected")] 
		public CBool WasDetected
		{
			get => GetProperty(ref _wasDetected);
			set => SetProperty(ref _wasDetected, value);
		}

		public PerkTrainingControllerPS(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
