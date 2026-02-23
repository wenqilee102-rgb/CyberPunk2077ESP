using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorExtractMountDataTaskDefinition : AIbehaviorTaskDefinition
	{
		private CHandle<AIArgumentMapping> _mountEventData;
		private CHandle<AIArgumentMapping> _outWorkspotData;
		private CHandle<AIArgumentMapping> _outIsInstant;
		private CHandle<AIArgumentMapping> _outAllowFailsafeTeleport;

		[Ordinal(1)] 
		[RED("mountEventData")] 
		public CHandle<AIArgumentMapping> MountEventData
		{
			get => GetProperty(ref _mountEventData);
			set => SetProperty(ref _mountEventData, value);
		}

		[Ordinal(2)] 
		[RED("outWorkspotData")] 
		public CHandle<AIArgumentMapping> OutWorkspotData
		{
			get => GetProperty(ref _outWorkspotData);
			set => SetProperty(ref _outWorkspotData, value);
		}

		[Ordinal(3)] 
		[RED("outIsInstant")] 
		public CHandle<AIArgumentMapping> OutIsInstant
		{
			get => GetProperty(ref _outIsInstant);
			set => SetProperty(ref _outIsInstant, value);
		}

		[Ordinal(4)] 
		[RED("outAllowFailsafeTeleport")] 
		public CHandle<AIArgumentMapping> OutAllowFailsafeTeleport
		{
			get => GetProperty(ref _outAllowFailsafeTeleport);
			set => SetProperty(ref _outAllowFailsafeTeleport, value);
		}

		public AIbehaviorExtractMountDataTaskDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
