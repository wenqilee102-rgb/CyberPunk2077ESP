using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiCharacterCustomizationVersionUpdateInfo : CVariable
	{
		private CUInt32 _newVersion;
		private CArray<gameuiCharacterCustomizationOptionVersionUpdateInfo> _optionUpdates;

		[Ordinal(0)] 
		[RED("newVersion")] 
		public CUInt32 NewVersion
		{
			get => GetProperty(ref _newVersion);
			set => SetProperty(ref _newVersion, value);
		}

		[Ordinal(1)] 
		[RED("optionUpdates")] 
		public CArray<gameuiCharacterCustomizationOptionVersionUpdateInfo> OptionUpdates
		{
			get => GetProperty(ref _optionUpdates);
			set => SetProperty(ref _optionUpdates, value);
		}

		public gameuiCharacterCustomizationVersionUpdateInfo(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
