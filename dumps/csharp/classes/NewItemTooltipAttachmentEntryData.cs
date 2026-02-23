using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NewItemTooltipAttachmentEntryData : IScriptable
	{
		private CString _text;
		private CName _colorState;
		private CHandle<gameUILocalizationDataPackage> _dataPackage;
		private CHandle<UIInventoryItemModAttunementData> _attunementData;

		[Ordinal(0)] 
		[RED("text")] 
		public CString Text
		{
			get => GetProperty(ref _text);
			set => SetProperty(ref _text, value);
		}

		[Ordinal(1)] 
		[RED("colorState")] 
		public CName ColorState
		{
			get => GetProperty(ref _colorState);
			set => SetProperty(ref _colorState, value);
		}

		[Ordinal(2)] 
		[RED("dataPackage")] 
		public CHandle<gameUILocalizationDataPackage> DataPackage
		{
			get => GetProperty(ref _dataPackage);
			set => SetProperty(ref _dataPackage, value);
		}

		[Ordinal(3)] 
		[RED("attunementData")] 
		public CHandle<UIInventoryItemModAttunementData> AttunementData
		{
			get => GetProperty(ref _attunementData);
			set => SetProperty(ref _attunementData, value);
		}

		public NewItemTooltipAttachmentEntryData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
