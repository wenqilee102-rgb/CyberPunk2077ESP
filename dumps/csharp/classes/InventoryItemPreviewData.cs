using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InventoryItemPreviewData : inkGameNotificationData
	{
		private gameItemID _itemID;
		private CString _itemName;
		private CString _itemDescription;
		private CInt32 _requiredLevel;
		private CName _itemQualityState;
		private CEnum<gamedataWeaponEvolution> _itemEvolution;
		private CEnum<gamedataPerkWeaponGroupType> _itemPerkGroup;

		[Ordinal(7)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get => GetProperty(ref _itemID);
			set => SetProperty(ref _itemID, value);
		}

		[Ordinal(8)] 
		[RED("itemName")] 
		public CString ItemName
		{
			get => GetProperty(ref _itemName);
			set => SetProperty(ref _itemName, value);
		}

		[Ordinal(9)] 
		[RED("itemDescription")] 
		public CString ItemDescription
		{
			get => GetProperty(ref _itemDescription);
			set => SetProperty(ref _itemDescription, value);
		}

		[Ordinal(10)] 
		[RED("requiredLevel")] 
		public CInt32 RequiredLevel
		{
			get => GetProperty(ref _requiredLevel);
			set => SetProperty(ref _requiredLevel, value);
		}

		[Ordinal(11)] 
		[RED("itemQualityState")] 
		public CName ItemQualityState
		{
			get => GetProperty(ref _itemQualityState);
			set => SetProperty(ref _itemQualityState, value);
		}

		[Ordinal(12)] 
		[RED("itemEvolution")] 
		public CEnum<gamedataWeaponEvolution> ItemEvolution
		{
			get => GetProperty(ref _itemEvolution);
			set => SetProperty(ref _itemEvolution, value);
		}

		[Ordinal(13)] 
		[RED("itemPerkGroup")] 
		public CEnum<gamedataPerkWeaponGroupType> ItemPerkGroup
		{
			get => GetProperty(ref _itemPerkGroup);
			set => SetProperty(ref _itemPerkGroup, value);
		}

		public InventoryItemPreviewData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
