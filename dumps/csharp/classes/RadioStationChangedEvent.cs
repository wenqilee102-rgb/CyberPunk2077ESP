using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RadioStationChangedEvent : redEvent
	{
		private CInt32 _radioIndex;

		[Ordinal(0)] 
		[RED("radioIndex")] 
		public CInt32 RadioIndex
		{
			get => GetProperty(ref _radioIndex);
			set => SetProperty(ref _radioIndex, value);
		}

		public RadioStationChangedEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
