using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class previewTargetStruct : CVariable
	{
		private wCHandle<gameObject> _currentlyTrackedTarget;
		private CEnum<EHitReactionZone> _currentBodyPart;
		private CBool _currentlyHittingBreach;

		[Ordinal(0)] 
		[RED("currentlyTrackedTarget")] 
		public wCHandle<gameObject> CurrentlyTrackedTarget
		{
			get => GetProperty(ref _currentlyTrackedTarget);
			set => SetProperty(ref _currentlyTrackedTarget, value);
		}

		[Ordinal(1)] 
		[RED("currentBodyPart")] 
		public CEnum<EHitReactionZone> CurrentBodyPart
		{
			get => GetProperty(ref _currentBodyPart);
			set => SetProperty(ref _currentBodyPart, value);
		}

		[Ordinal(2)] 
		[RED("currentlyHittingBreach")] 
		public CBool CurrentlyHittingBreach
		{
			get => GetProperty(ref _currentlyHittingBreach);
			set => SetProperty(ref _currentlyHittingBreach, value);
		}

		public previewTargetStruct(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
