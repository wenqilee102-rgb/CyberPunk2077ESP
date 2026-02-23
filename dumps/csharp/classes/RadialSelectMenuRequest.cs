using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RadialSelectMenuRequest : redEvent
	{
		private wCHandle<RadialMenuItemController> _eventData;

		[Ordinal(0)] 
		[RED("eventData")] 
		public wCHandle<RadialMenuItemController> EventData
		{
			get => GetProperty(ref _eventData);
			set => SetProperty(ref _eventData, value);
		}

		public RadialSelectMenuRequest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
