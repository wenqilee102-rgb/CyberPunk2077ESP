using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class OnSpecialQuickhackTriggeredEvent : DelayEvent
	{
		private CHandle<QuickhackData> _quickhackData;

		[Ordinal(39)] 
		[RED("quickhackData")] 
		public CHandle<QuickhackData> QuickhackData
		{
			get => GetProperty(ref _quickhackData);
			set => SetProperty(ref _quickhackData, value);
		}

		public OnSpecialQuickhackTriggeredEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
