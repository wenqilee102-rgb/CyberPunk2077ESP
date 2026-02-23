using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameJournalEntryOverrideData : IScriptable
	{
		private CEnum<inputESimplifiedInputDevice> _inputDevice;
		private CEnum<inputEInputScheme> _inputScheme;
		private LocalizationString _overriddenLocalizationString;

		[Ordinal(0)] 
		[RED("inputDevice")] 
		public CEnum<inputESimplifiedInputDevice> InputDevice
		{
			get => GetProperty(ref _inputDevice);
			set => SetProperty(ref _inputDevice, value);
		}

		[Ordinal(1)] 
		[RED("inputScheme")] 
		public CEnum<inputEInputScheme> InputScheme
		{
			get => GetProperty(ref _inputScheme);
			set => SetProperty(ref _inputScheme, value);
		}

		[Ordinal(2)] 
		[RED("overriddenLocalizationString")] 
		public LocalizationString OverriddenLocalizationString
		{
			get => GetProperty(ref _overriddenLocalizationString);
			set => SetProperty(ref _overriddenLocalizationString, value);
		}

		public gameJournalEntryOverrideData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
