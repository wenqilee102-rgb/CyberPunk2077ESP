using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FixerTooltipMapData : CVariable
	{
		private CName _fixerLocKey;
		private CHandle<gamedataUIIcon_Record> _fixerIcon;
		private CName _fixerDescription;
		private CName _additionalDescriptionKey;
		private CInt32 _allQuestsAmount;
		private CInt32 _generalQuestsProgress;
		private CInt32 _allQuestsInCurrentPackage;
		private CInt32 _currentPackageProgress;

		[Ordinal(0)] 
		[RED("fixerLocKey")] 
		public CName FixerLocKey
		{
			get => GetProperty(ref _fixerLocKey);
			set => SetProperty(ref _fixerLocKey, value);
		}

		[Ordinal(1)] 
		[RED("fixerIcon")] 
		public CHandle<gamedataUIIcon_Record> FixerIcon
		{
			get => GetProperty(ref _fixerIcon);
			set => SetProperty(ref _fixerIcon, value);
		}

		[Ordinal(2)] 
		[RED("fixerDescription")] 
		public CName FixerDescription
		{
			get => GetProperty(ref _fixerDescription);
			set => SetProperty(ref _fixerDescription, value);
		}

		[Ordinal(3)] 
		[RED("additionalDescriptionKey")] 
		public CName AdditionalDescriptionKey
		{
			get => GetProperty(ref _additionalDescriptionKey);
			set => SetProperty(ref _additionalDescriptionKey, value);
		}

		[Ordinal(4)] 
		[RED("allQuestsAmount")] 
		public CInt32 AllQuestsAmount
		{
			get => GetProperty(ref _allQuestsAmount);
			set => SetProperty(ref _allQuestsAmount, value);
		}

		[Ordinal(5)] 
		[RED("generalQuestsProgress")] 
		public CInt32 GeneralQuestsProgress
		{
			get => GetProperty(ref _generalQuestsProgress);
			set => SetProperty(ref _generalQuestsProgress, value);
		}

		[Ordinal(6)] 
		[RED("allQuestsInCurrentPackage")] 
		public CInt32 AllQuestsInCurrentPackage
		{
			get => GetProperty(ref _allQuestsInCurrentPackage);
			set => SetProperty(ref _allQuestsInCurrentPackage, value);
		}

		[Ordinal(7)] 
		[RED("currentPackageProgress")] 
		public CInt32 CurrentPackageProgress
		{
			get => GetProperty(ref _currentPackageProgress);
			set => SetProperty(ref _currentPackageProgress, value);
		}

		public FixerTooltipMapData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
