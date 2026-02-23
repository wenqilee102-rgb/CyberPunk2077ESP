using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiCasinoChips : gameObject
	{
		private CArray<CName> _digitNames;
		private CArray<CName> _flippedDigitNames;

		[Ordinal(36)] 
		[RED("digitNames")] 
		public CArray<CName> DigitNames
		{
			get => GetProperty(ref _digitNames);
			set => SetProperty(ref _digitNames, value);
		}

		[Ordinal(37)] 
		[RED("flippedDigitNames")] 
		public CArray<CName> FlippedDigitNames
		{
			get => GetProperty(ref _flippedDigitNames);
			set => SetProperty(ref _flippedDigitNames, value);
		}

		public gameuiCasinoChips(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
