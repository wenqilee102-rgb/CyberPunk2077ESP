using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RipperdocWrappedUIInventoryItem : IScriptable
	{
		private wCHandle<UIInventoryItem> _inventoryItem;
		private CFloat _delay;
		private CHandle<ItemDisplayContextData> _displayContext;
		private CBool _isEnoughMoney;
		private CBool _isNew;
		private CBool _isEquippable;
		private CFloat _itemPrice;
		private CBool _isBuybackStack;
		private CHandle<IScriptable> _additionalData;

		[Ordinal(0)] 
		[RED("InventoryItem")] 
		public wCHandle<UIInventoryItem> InventoryItem
		{
			get => GetProperty(ref _inventoryItem);
			set => SetProperty(ref _inventoryItem, value);
		}

		[Ordinal(1)] 
		[RED("Delay")] 
		public CFloat Delay
		{
			get => GetProperty(ref _delay);
			set => SetProperty(ref _delay, value);
		}

		[Ordinal(2)] 
		[RED("DisplayContext")] 
		public CHandle<ItemDisplayContextData> DisplayContext
		{
			get => GetProperty(ref _displayContext);
			set => SetProperty(ref _displayContext, value);
		}

		[Ordinal(3)] 
		[RED("IsEnoughMoney")] 
		public CBool IsEnoughMoney
		{
			get => GetProperty(ref _isEnoughMoney);
			set => SetProperty(ref _isEnoughMoney, value);
		}

		[Ordinal(4)] 
		[RED("IsNew")] 
		public CBool IsNew
		{
			get => GetProperty(ref _isNew);
			set => SetProperty(ref _isNew, value);
		}

		[Ordinal(5)] 
		[RED("IsEquippable")] 
		public CBool IsEquippable
		{
			get => GetProperty(ref _isEquippable);
			set => SetProperty(ref _isEquippable, value);
		}

		[Ordinal(6)] 
		[RED("ItemPrice")] 
		public CFloat ItemPrice
		{
			get => GetProperty(ref _itemPrice);
			set => SetProperty(ref _itemPrice, value);
		}

		[Ordinal(7)] 
		[RED("IsBuybackStack")] 
		public CBool IsBuybackStack
		{
			get => GetProperty(ref _isBuybackStack);
			set => SetProperty(ref _isBuybackStack, value);
		}

		[Ordinal(8)] 
		[RED("AdditionalData")] 
		public CHandle<IScriptable> AdditionalData
		{
			get => GetProperty(ref _additionalData);
			set => SetProperty(ref _additionalData, value);
		}

		public RipperdocWrappedUIInventoryItem(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
