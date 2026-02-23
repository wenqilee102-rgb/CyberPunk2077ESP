using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class senseSensorOwnerChangedEvent : redEvent
	{
		private entEntityID _newOwnerId;

		[Ordinal(0)] 
		[RED("newOwnerId")] 
		public entEntityID NewOwnerId
		{
			get => GetProperty(ref _newOwnerId);
			set => SetProperty(ref _newOwnerId, value);
		}

		public senseSensorOwnerChangedEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
