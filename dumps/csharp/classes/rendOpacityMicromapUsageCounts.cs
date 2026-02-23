using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class rendOpacityMicromapUsageCounts : CVariable
	{
		private CUInt32 _bdivisionLevel;
		private CUInt32 _rmat;
		private CUInt32 _unt;

		[Ordinal(0)] 
		[RED("bdivisionLevel")] 
		public CUInt32 BdivisionLevel
		{
			get => GetProperty(ref _bdivisionLevel);
			set => SetProperty(ref _bdivisionLevel, value);
		}

		[Ordinal(1)] 
		[RED("rmat")] 
		public CUInt32 Rmat
		{
			get => GetProperty(ref _rmat);
			set => SetProperty(ref _rmat, value);
		}

		[Ordinal(2)] 
		[RED("unt")] 
		public CUInt32 Unt
		{
			get => GetProperty(ref _unt);
			set => SetProperty(ref _unt, value);
		}

		public rendOpacityMicromapUsageCounts(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
