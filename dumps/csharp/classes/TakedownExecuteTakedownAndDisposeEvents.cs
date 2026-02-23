using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TakedownExecuteTakedownAndDisposeEvents : LocomotionTakedownEvents
	{
		private entEntityID _targetID;

		[Ordinal(7)] 
		[RED("targetID")] 
		public entEntityID TargetID
		{
			get => GetProperty(ref _targetID);
			set => SetProperty(ref _targetID, value);
		}

		public TakedownExecuteTakedownAndDisposeEvents(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
