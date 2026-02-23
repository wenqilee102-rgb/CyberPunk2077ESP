using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UIInventoryItemModDataPackage : UIInventoryItemMod
	{
		private CString _description;
		private CHandle<gameUILocalizationDataPackage> _dataPackage;
		private CHandle<UIInventoryItemModAttunementData> _attunementData;

		[Ordinal(0)] 
		[RED("Description")] 
		public CString Description
		{
			get => GetProperty(ref _description);
			set => SetProperty(ref _description, value);
		}

		[Ordinal(1)] 
		[RED("DataPackage")] 
		public CHandle<gameUILocalizationDataPackage> DataPackage
		{
			get => GetProperty(ref _dataPackage);
			set => SetProperty(ref _dataPackage, value);
		}

		[Ordinal(2)] 
		[RED("AttunementData")] 
		public CHandle<UIInventoryItemModAttunementData> AttunementData
		{
			get => GetProperty(ref _attunementData);
			set => SetProperty(ref _attunementData, value);
		}

		public UIInventoryItemModDataPackage(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
