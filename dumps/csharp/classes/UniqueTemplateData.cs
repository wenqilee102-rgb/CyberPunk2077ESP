using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UniqueTemplateData : CVariable
	{
		private TweakDBID _recordId;
		private CName _twintoneModelName;
		private CHandle<gamedataUIIcon_Record> _customIcon;
		private CArray<vehicleVehicleCustomMultilayer> _customMultilayers;
		private CArray<vehicleVehicleDecalAttachmentData> _customDecals;
		private vehicleVehicleClearCoatOverrides _globalClearCoatOverrides;
		private CArray<vehicleVehiclePartsClearCoatOverrides> _partsClearCoatOverrides;

		[Ordinal(0)] 
		[RED("recordId")] 
		public TweakDBID RecordId
		{
			get => GetProperty(ref _recordId);
			set => SetProperty(ref _recordId, value);
		}

		[Ordinal(1)] 
		[RED("twintoneModelName")] 
		public CName TwintoneModelName
		{
			get => GetProperty(ref _twintoneModelName);
			set => SetProperty(ref _twintoneModelName, value);
		}

		[Ordinal(2)] 
		[RED("customIcon")] 
		public CHandle<gamedataUIIcon_Record> CustomIcon
		{
			get => GetProperty(ref _customIcon);
			set => SetProperty(ref _customIcon, value);
		}

		[Ordinal(3)] 
		[RED("customMultilayers")] 
		public CArray<vehicleVehicleCustomMultilayer> CustomMultilayers
		{
			get => GetProperty(ref _customMultilayers);
			set => SetProperty(ref _customMultilayers, value);
		}

		[Ordinal(4)] 
		[RED("customDecals")] 
		public CArray<vehicleVehicleDecalAttachmentData> CustomDecals
		{
			get => GetProperty(ref _customDecals);
			set => SetProperty(ref _customDecals, value);
		}

		[Ordinal(5)] 
		[RED("globalClearCoatOverrides")] 
		public vehicleVehicleClearCoatOverrides GlobalClearCoatOverrides
		{
			get => GetProperty(ref _globalClearCoatOverrides);
			set => SetProperty(ref _globalClearCoatOverrides, value);
		}

		[Ordinal(6)] 
		[RED("partsClearCoatOverrides")] 
		public CArray<vehicleVehiclePartsClearCoatOverrides> PartsClearCoatOverrides
		{
			get => GetProperty(ref _partsClearCoatOverrides);
			set => SetProperty(ref _partsClearCoatOverrides, value);
		}

		public UniqueTemplateData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
