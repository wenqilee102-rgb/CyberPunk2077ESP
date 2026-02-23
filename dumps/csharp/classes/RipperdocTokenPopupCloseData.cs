using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RipperdocTokenPopupCloseData : inkGameNotificationData
	{
		private CBool _confirm;
		private CInt32 _chosenOptionIndex;
		private CHandle<gameItemData> _chosenOptionData;
		private CyberwareUpgradeCostData _costData;

		[Ordinal(7)] 
		[RED("confirm")] 
		public CBool Confirm
		{
			get => GetProperty(ref _confirm);
			set => SetProperty(ref _confirm, value);
		}

		[Ordinal(8)] 
		[RED("chosenOptionIndex")] 
		public CInt32 ChosenOptionIndex
		{
			get => GetProperty(ref _chosenOptionIndex);
			set => SetProperty(ref _chosenOptionIndex, value);
		}

		[Ordinal(9)] 
		[RED("chosenOptionData")] 
		public CHandle<gameItemData> ChosenOptionData
		{
			get => GetProperty(ref _chosenOptionData);
			set => SetProperty(ref _chosenOptionData, value);
		}

		[Ordinal(10)] 
		[RED("costData")] 
		public CyberwareUpgradeCostData CostData
		{
			get => GetProperty(ref _costData);
			set => SetProperty(ref _costData, value);
		}

		public RipperdocTokenPopupCloseData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
