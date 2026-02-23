using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QueueQuickHackEvent : redEvent
	{
		private gameNewMappinID _mappinID;
		private CHandle<GameplayRoleMappinData> _data;

		[Ordinal(0)] 
		[RED("mappinID")] 
		public gameNewMappinID MappinID
		{
			get => GetProperty(ref _mappinID);
			set => SetProperty(ref _mappinID, value);
		}

		[Ordinal(1)] 
		[RED("data")] 
		public CHandle<GameplayRoleMappinData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		public QueueQuickHackEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
