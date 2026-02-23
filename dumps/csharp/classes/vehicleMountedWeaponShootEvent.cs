using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleMountedWeaponShootEvent : redEvent
	{
		private TweakDBID _weaponID;
		private TweakDBID _slotID;

		[Ordinal(0)] 
		[RED("weaponID")] 
		public TweakDBID WeaponID
		{
			get => GetProperty(ref _weaponID);
			set => SetProperty(ref _weaponID, value);
		}

		[Ordinal(1)] 
		[RED("slotID")] 
		public TweakDBID SlotID
		{
			get => GetProperty(ref _slotID);
			set => SetProperty(ref _slotID, value);
		}

		public vehicleMountedWeaponShootEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
