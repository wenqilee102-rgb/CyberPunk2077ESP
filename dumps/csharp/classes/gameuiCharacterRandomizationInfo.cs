using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiCharacterRandomizationInfo : CVariable
	{
		private CUInt32 _minRating;
		private CUInt32 _maxRating;

		[Ordinal(0)] 
		[RED("minRating")] 
		public CUInt32 MinRating
		{
			get => GetProperty(ref _minRating);
			set => SetProperty(ref _minRating, value);
		}

		[Ordinal(1)] 
		[RED("maxRating")] 
		public CUInt32 MaxRating
		{
			get => GetProperty(ref _maxRating);
			set => SetProperty(ref _maxRating, value);
		}

		public gameuiCharacterRandomizationInfo(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
