using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BunkerSystemsFactsSet : CVariable
	{
		private CName _aLPHA_FACT;
		private CName _bRAVO_FACT;
		private CName _sIERRA_FACT;
		private CName _vICTOR_FACT;

		[Ordinal(0)] 
		[RED("ALPHA_FACT")] 
		public CName ALPHA_FACT
		{
			get => GetProperty(ref _aLPHA_FACT);
			set => SetProperty(ref _aLPHA_FACT, value);
		}

		[Ordinal(1)] 
		[RED("BRAVO_FACT")] 
		public CName BRAVO_FACT
		{
			get => GetProperty(ref _bRAVO_FACT);
			set => SetProperty(ref _bRAVO_FACT, value);
		}

		[Ordinal(2)] 
		[RED("SIERRA_FACT")] 
		public CName SIERRA_FACT
		{
			get => GetProperty(ref _sIERRA_FACT);
			set => SetProperty(ref _sIERRA_FACT, value);
		}

		[Ordinal(3)] 
		[RED("VICTOR_FACT")] 
		public CName VICTOR_FACT
		{
			get => GetProperty(ref _vICTOR_FACT);
			set => SetProperty(ref _vICTOR_FACT, value);
		}

		public BunkerSystemsFactsSet(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
