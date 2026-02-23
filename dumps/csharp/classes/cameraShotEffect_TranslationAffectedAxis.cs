using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class cameraShotEffect_TranslationAffectedAxis : CVariable
	{
		private CBool _x;
		private CBool _y;
		private CBool _z;

		[Ordinal(0)] 
		[RED("X")] 
		public CBool X
		{
			get => GetProperty(ref _x);
			set => SetProperty(ref _x, value);
		}

		[Ordinal(1)] 
		[RED("Y")] 
		public CBool Y
		{
			get => GetProperty(ref _y);
			set => SetProperty(ref _y, value);
		}

		[Ordinal(2)] 
		[RED("Z")] 
		public CBool Z
		{
			get => GetProperty(ref _z);
			set => SetProperty(ref _z, value);
		}

		public cameraShotEffect_TranslationAffectedAxis(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
