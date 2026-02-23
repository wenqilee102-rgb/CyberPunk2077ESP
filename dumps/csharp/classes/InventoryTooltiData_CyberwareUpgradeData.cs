using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InventoryTooltiData_CyberwareUpgradeData : IScriptable
	{
		private CEnum<gamedataQuality> _upgradeQuality;
		private CBool _isUpgradable;
		private CBool _isRipperdoc;
		private CBool _isUpgradeScreen;
		private CInt32 _playerComponents;
		private CyberwareUpgradeCostData _upgradeCost;

		[Ordinal(0)] 
		[RED("upgradeQuality")] 
		public CEnum<gamedataQuality> UpgradeQuality
		{
			get => GetProperty(ref _upgradeQuality);
			set => SetProperty(ref _upgradeQuality, value);
		}

		[Ordinal(1)] 
		[RED("isUpgradable")] 
		public CBool IsUpgradable
		{
			get => GetProperty(ref _isUpgradable);
			set => SetProperty(ref _isUpgradable, value);
		}

		[Ordinal(2)] 
		[RED("isRipperdoc")] 
		public CBool IsRipperdoc
		{
			get => GetProperty(ref _isRipperdoc);
			set => SetProperty(ref _isRipperdoc, value);
		}

		[Ordinal(3)] 
		[RED("isUpgradeScreen")] 
		public CBool IsUpgradeScreen
		{
			get => GetProperty(ref _isUpgradeScreen);
			set => SetProperty(ref _isUpgradeScreen, value);
		}

		[Ordinal(4)] 
		[RED("playerComponents")] 
		public CInt32 PlayerComponents
		{
			get => GetProperty(ref _playerComponents);
			set => SetProperty(ref _playerComponents, value);
		}

		[Ordinal(5)] 
		[RED("upgradeCost")] 
		public CyberwareUpgradeCostData UpgradeCost
		{
			get => GetProperty(ref _upgradeCost);
			set => SetProperty(ref _upgradeCost, value);
		}

		public InventoryTooltiData_CyberwareUpgradeData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
