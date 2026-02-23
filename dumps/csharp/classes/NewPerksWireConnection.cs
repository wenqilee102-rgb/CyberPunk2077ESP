using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NewPerksWireConnection : CVariable
	{
		private CEnum<gamedataNewPerkSlotType> _targetSlot;
		private CBool _dependanciesPresenceToggle;
		private CArray<CEnum<gamedataNewPerkSlotType>> _connectionDependancies;
		private CArray<inkWidgetReference> _wires;

		[Ordinal(0)] 
		[RED("targetSlot")] 
		public CEnum<gamedataNewPerkSlotType> TargetSlot
		{
			get => GetProperty(ref _targetSlot);
			set => SetProperty(ref _targetSlot, value);
		}

		[Ordinal(1)] 
		[RED("dependanciesPresenceToggle")] 
		public CBool DependanciesPresenceToggle
		{
			get => GetProperty(ref _dependanciesPresenceToggle);
			set => SetProperty(ref _dependanciesPresenceToggle, value);
		}

		[Ordinal(2)] 
		[RED("connectionDependancies")] 
		public CArray<CEnum<gamedataNewPerkSlotType>> ConnectionDependancies
		{
			get => GetProperty(ref _connectionDependancies);
			set => SetProperty(ref _connectionDependancies, value);
		}

		[Ordinal(3)] 
		[RED("wires")] 
		public CArray<inkWidgetReference> Wires
		{
			get => GetProperty(ref _wires);
			set => SetProperty(ref _wires, value);
		}

		public NewPerksWireConnection(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
