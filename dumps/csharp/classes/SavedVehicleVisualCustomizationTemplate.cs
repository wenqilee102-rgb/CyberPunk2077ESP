using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SavedVehicleVisualCustomizationTemplate : CVariable
	{
		private CBool _hasUniqueTemplate;
		private GenericTemplatePersistentData _genericData;
		private TweakDBID _uniqueDataID;
		private CName _twintoneModelName;

		[Ordinal(0)] 
		[RED("hasUniqueTemplate")] 
		public CBool HasUniqueTemplate
		{
			get => GetProperty(ref _hasUniqueTemplate);
			set => SetProperty(ref _hasUniqueTemplate, value);
		}

		[Ordinal(1)] 
		[RED("genericData")] 
		public GenericTemplatePersistentData GenericData
		{
			get => GetProperty(ref _genericData);
			set => SetProperty(ref _genericData, value);
		}

		[Ordinal(2)] 
		[RED("uniqueDataID")] 
		public TweakDBID UniqueDataID
		{
			get => GetProperty(ref _uniqueDataID);
			set => SetProperty(ref _uniqueDataID, value);
		}

		[Ordinal(3)] 
		[RED("twintoneModelName")] 
		public CName TwintoneModelName
		{
			get => GetProperty(ref _twintoneModelName);
			set => SetProperty(ref _twintoneModelName, value);
		}

		public SavedVehicleVisualCustomizationTemplate(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
