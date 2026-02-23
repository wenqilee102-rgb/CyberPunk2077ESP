using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class OverrideScannerPreset : redEvent
	{
		private TweakDBID _scannerPreset;

		[Ordinal(0)] 
		[RED("scannerPreset")] 
		public TweakDBID ScannerPreset
		{
			get => GetProperty(ref _scannerPreset);
			set => SetProperty(ref _scannerPreset, value);
		}

		public OverrideScannerPreset(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
