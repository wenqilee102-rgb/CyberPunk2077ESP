using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scneventsSpawnEntityEventParams : CVariable
	{
		private scnPerformerId _performer;
		private scnPerformerId _referencePerformer;
		private TweakDBID _referencePerformerSlotId;
		private TweakDBID _referencePerformerItemId;
		private CArray<scneventsSpawnEntityEventFallbackData> _fallbackData;

		[Ordinal(0)] 
		[RED("performer")] 
		public scnPerformerId Performer
		{
			get => GetProperty(ref _performer);
			set => SetProperty(ref _performer, value);
		}

		[Ordinal(1)] 
		[RED("referencePerformer")] 
		public scnPerformerId ReferencePerformer
		{
			get => GetProperty(ref _referencePerformer);
			set => SetProperty(ref _referencePerformer, value);
		}

		[Ordinal(2)] 
		[RED("referencePerformerSlotId")] 
		public TweakDBID ReferencePerformerSlotId
		{
			get => GetProperty(ref _referencePerformerSlotId);
			set => SetProperty(ref _referencePerformerSlotId, value);
		}

		[Ordinal(3)] 
		[RED("referencePerformerItemId")] 
		public TweakDBID ReferencePerformerItemId
		{
			get => GetProperty(ref _referencePerformerItemId);
			set => SetProperty(ref _referencePerformerItemId, value);
		}

		[Ordinal(4)] 
		[RED("fallbackData")] 
		public CArray<scneventsSpawnEntityEventFallbackData> FallbackData
		{
			get => GetProperty(ref _fallbackData);
			set => SetProperty(ref _fallbackData, value);
		}

		public scneventsSpawnEntityEventParams(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
