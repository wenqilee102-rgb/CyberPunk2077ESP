using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UnlockAnimData : CVariable
	{
		private CInt32 _levelFrom;
		private CInt32 _levelTo;

		[Ordinal(0)] 
		[RED("levelFrom")] 
		public CInt32 LevelFrom
		{
			get => GetProperty(ref _levelFrom);
			set => SetProperty(ref _levelFrom, value);
		}

		[Ordinal(1)] 
		[RED("levelTo")] 
		public CInt32 LevelTo
		{
			get => GetProperty(ref _levelTo);
			set => SetProperty(ref _levelTo, value);
		}

		public UnlockAnimData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
