using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCharacterManagerParameters_SetSensePreset : questICharacterManagerParameters_NodeSubType
	{
		private gameEntityReference _puppetRef;
		private TweakDBID _presetID;
		private CBool _main;
		private CBool _resetToMain;

		[Ordinal(0)] 
		[RED("puppetRef")] 
		public gameEntityReference PuppetRef
		{
			get => GetProperty(ref _puppetRef);
			set => SetProperty(ref _puppetRef, value);
		}

		[Ordinal(1)] 
		[RED("presetID")] 
		public TweakDBID PresetID
		{
			get => GetProperty(ref _presetID);
			set => SetProperty(ref _presetID, value);
		}

		[Ordinal(2)] 
		[RED("main")] 
		public CBool Main
		{
			get => GetProperty(ref _main);
			set => SetProperty(ref _main, value);
		}

		[Ordinal(3)] 
		[RED("resetToMain")] 
		public CBool ResetToMain
		{
			get => GetProperty(ref _resetToMain);
			set => SetProperty(ref _resetToMain, value);
		}

		public questCharacterManagerParameters_SetSensePreset(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
