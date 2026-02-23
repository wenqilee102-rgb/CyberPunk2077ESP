using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CyberwareUpgradeCostData : CVariable
	{
		private TweakDBID _materialRecordID;
		private CInt32 _materialCount;
		private CInt32 _moneyRequired;

		[Ordinal(0)] 
		[RED("materialRecordID")] 
		public TweakDBID MaterialRecordID
		{
			get => GetProperty(ref _materialRecordID);
			set => SetProperty(ref _materialRecordID, value);
		}

		[Ordinal(1)] 
		[RED("materialCount")] 
		public CInt32 MaterialCount
		{
			get => GetProperty(ref _materialCount);
			set => SetProperty(ref _materialCount, value);
		}

		[Ordinal(2)] 
		[RED("moneyRequired")] 
		public CInt32 MoneyRequired
		{
			get => GetProperty(ref _moneyRequired);
			set => SetProperty(ref _moneyRequired, value);
		}

		public CyberwareUpgradeCostData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
