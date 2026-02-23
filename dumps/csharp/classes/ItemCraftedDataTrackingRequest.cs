using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemCraftedDataTrackingRequest : gamePlayerScriptableSystemRequest
	{
		private gameItemID _targetItem;
		private CInt32 _amount;

		[Ordinal(1)] 
		[RED("targetItem")] 
		public gameItemID TargetItem
		{
			get => GetProperty(ref _targetItem);
			set => SetProperty(ref _targetItem, value);
		}

		[Ordinal(2)] 
		[RED("amount")] 
		public CInt32 Amount
		{
			get => GetProperty(ref _amount);
			set => SetProperty(ref _amount, value);
		}

		public ItemCraftedDataTrackingRequest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
