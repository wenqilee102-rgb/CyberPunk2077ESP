using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MinimalLootingListItemData : IScriptable
	{
		private wCHandle<gameItemData> _gameItemData;
		private gameItemID _itemId;
		private CString _itemName;
		private CString _itemCategoryName;
		private CEnum<gamedataItemType> _itemType;
		private CEnum<gamedataEquipmentArea> _equipmentArea;
		private CEnum<gamedataQuality> _quality;
		private CBool _isIconic;
		private CInt32 _quantity;
		private CEnum<gameLootItemType> _lootItemType;
		private CBool _isQuestContainer;
		private TweakDBID _tweakDBID;
		private CFloat _dpsDiff;
		private CFloat _armorDiff;
		private CFloat _qualityF;
		private CFloat _comparedQualityF;

		[Ordinal(0)] 
		[RED("gameItemData")] 
		public wCHandle<gameItemData> GameItemData
		{
			get => GetProperty(ref _gameItemData);
			set => SetProperty(ref _gameItemData, value);
		}

		[Ordinal(1)] 
		[RED("itemId")] 
		public gameItemID ItemId
		{
			get => GetProperty(ref _itemId);
			set => SetProperty(ref _itemId, value);
		}

		[Ordinal(2)] 
		[RED("itemName")] 
		public CString ItemName
		{
			get => GetProperty(ref _itemName);
			set => SetProperty(ref _itemName, value);
		}

		[Ordinal(3)] 
		[RED("itemCategoryName")] 
		public CString ItemCategoryName
		{
			get => GetProperty(ref _itemCategoryName);
			set => SetProperty(ref _itemCategoryName, value);
		}

		[Ordinal(4)] 
		[RED("itemType")] 
		public CEnum<gamedataItemType> ItemType
		{
			get => GetProperty(ref _itemType);
			set => SetProperty(ref _itemType, value);
		}

		[Ordinal(5)] 
		[RED("equipmentArea")] 
		public CEnum<gamedataEquipmentArea> EquipmentArea
		{
			get => GetProperty(ref _equipmentArea);
			set => SetProperty(ref _equipmentArea, value);
		}

		[Ordinal(6)] 
		[RED("quality")] 
		public CEnum<gamedataQuality> Quality
		{
			get => GetProperty(ref _quality);
			set => SetProperty(ref _quality, value);
		}

		[Ordinal(7)] 
		[RED("isIconic")] 
		public CBool IsIconic
		{
			get => GetProperty(ref _isIconic);
			set => SetProperty(ref _isIconic, value);
		}

		[Ordinal(8)] 
		[RED("quantity")] 
		public CInt32 Quantity
		{
			get => GetProperty(ref _quantity);
			set => SetProperty(ref _quantity, value);
		}

		[Ordinal(9)] 
		[RED("lootItemType")] 
		public CEnum<gameLootItemType> LootItemType
		{
			get => GetProperty(ref _lootItemType);
			set => SetProperty(ref _lootItemType, value);
		}

		[Ordinal(10)] 
		[RED("isQuestContainer")] 
		public CBool IsQuestContainer
		{
			get => GetProperty(ref _isQuestContainer);
			set => SetProperty(ref _isQuestContainer, value);
		}

		[Ordinal(11)] 
		[RED("tweakDBID")] 
		public TweakDBID TweakDBID
		{
			get => GetProperty(ref _tweakDBID);
			set => SetProperty(ref _tweakDBID, value);
		}

		[Ordinal(12)] 
		[RED("dpsDiff")] 
		public CFloat DpsDiff
		{
			get => GetProperty(ref _dpsDiff);
			set => SetProperty(ref _dpsDiff, value);
		}

		[Ordinal(13)] 
		[RED("armorDiff")] 
		public CFloat ArmorDiff
		{
			get => GetProperty(ref _armorDiff);
			set => SetProperty(ref _armorDiff, value);
		}

		[Ordinal(14)] 
		[RED("qualityF")] 
		public CFloat QualityF
		{
			get => GetProperty(ref _qualityF);
			set => SetProperty(ref _qualityF, value);
		}

		[Ordinal(15)] 
		[RED("comparedQualityF")] 
		public CFloat ComparedQualityF
		{
			get => GetProperty(ref _comparedQualityF);
			set => SetProperty(ref _comparedQualityF, value);
		}

		public MinimalLootingListItemData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
