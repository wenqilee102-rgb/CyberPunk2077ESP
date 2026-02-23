using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NewPerksPerkContainerLogicController : inkWidgetLogicController
	{
		private CEnum<gamedataNewPerkSlotType> _slotIdentifier;
		private inkWidgetReference _perkWidget;
		private CArray<NewPerksWireConnection> _wiresConnections;

		[Ordinal(1)] 
		[RED("slotIdentifier")] 
		public CEnum<gamedataNewPerkSlotType> SlotIdentifier
		{
			get => GetProperty(ref _slotIdentifier);
			set => SetProperty(ref _slotIdentifier, value);
		}

		[Ordinal(2)] 
		[RED("perkWidget")] 
		public inkWidgetReference PerkWidget
		{
			get => GetProperty(ref _perkWidget);
			set => SetProperty(ref _perkWidget, value);
		}

		[Ordinal(3)] 
		[RED("wiresConnections")] 
		public CArray<NewPerksWireConnection> WiresConnections
		{
			get => GetProperty(ref _wiresConnections);
			set => SetProperty(ref _wiresConnections, value);
		}

		public NewPerksPerkContainerLogicController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
