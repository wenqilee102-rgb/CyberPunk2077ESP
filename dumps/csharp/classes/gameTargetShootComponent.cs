using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameTargetShootComponent : entIComponent
	{
		private CHandle<gamedataWeaponItem_Record> _weaponRecord;
		private TweakDBID _weaponTDBID;
		private CHandle<gamedataCharacter_Record> _characterRecord;
		private TweakDBID _characterTDBID;

		[Ordinal(3)] 
		[RED("weaponRecord")] 
		public CHandle<gamedataWeaponItem_Record> WeaponRecord
		{
			get => GetProperty(ref _weaponRecord);
			set => SetProperty(ref _weaponRecord, value);
		}

		[Ordinal(4)] 
		[RED("weaponTDBID")] 
		public TweakDBID WeaponTDBID
		{
			get => GetProperty(ref _weaponTDBID);
			set => SetProperty(ref _weaponTDBID, value);
		}

		[Ordinal(5)] 
		[RED("characterRecord")] 
		public CHandle<gamedataCharacter_Record> CharacterRecord
		{
			get => GetProperty(ref _characterRecord);
			set => SetProperty(ref _characterRecord, value);
		}

		[Ordinal(6)] 
		[RED("characterTDBID")] 
		public TweakDBID CharacterTDBID
		{
			get => GetProperty(ref _characterTDBID);
			set => SetProperty(ref _characterTDBID, value);
		}

		public gameTargetShootComponent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
