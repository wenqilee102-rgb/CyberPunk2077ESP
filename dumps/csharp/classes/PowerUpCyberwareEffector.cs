using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PowerUpCyberwareEffector : gameEffector
	{
		private CEnum<gamedataEquipmentArea> _targetEquipArea;
		private CInt32 _targetEquipSlotIndex;
		private wCHandle<EquipmentSystemPlayerData> _playerData;
		private wCHandle<gameObject> _owner;

		[Ordinal(0)] 
		[RED("targetEquipArea")] 
		public CEnum<gamedataEquipmentArea> TargetEquipArea
		{
			get => GetProperty(ref _targetEquipArea);
			set => SetProperty(ref _targetEquipArea, value);
		}

		[Ordinal(1)] 
		[RED("targetEquipSlotIndex")] 
		public CInt32 TargetEquipSlotIndex
		{
			get => GetProperty(ref _targetEquipSlotIndex);
			set => SetProperty(ref _targetEquipSlotIndex, value);
		}

		[Ordinal(2)] 
		[RED("playerData")] 
		public wCHandle<EquipmentSystemPlayerData> PlayerData
		{
			get => GetProperty(ref _playerData);
			set => SetProperty(ref _playerData, value);
		}

		[Ordinal(3)] 
		[RED("owner")] 
		public wCHandle<gameObject> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		public PowerUpCyberwareEffector(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
